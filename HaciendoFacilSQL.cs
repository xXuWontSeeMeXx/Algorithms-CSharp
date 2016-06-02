using System;
using System.IO;

public class HaciendoFacilSQL{
    public void Execute(){
        StreamReader sr = new StreamReader("archivo.txt");
        string entrada;
        while((entrada = sr.ReadLine()) != null)
        {
            Console.Write("SELECT ");
            int idxParentesis = entrada.IndexOf("(");
            string tabla = entrada.Substring(13, idxParentesis - 13);
            string columnas = entrada.Substring(idxParentesis + 1, entrada.Length - idxParentesis - 1);
            columnas += ", ";
            int idxSpace = 0;
            int idxComa = 0;
            while(idxSpace != -1 || idxComa != -1)
            {
                idxSpace = columnas.IndexOf(" ");
                idxComa = columnas.IndexOf(", ");
                if(idxSpace == -1 || idxComa == -1)
                    break;
                idxComa += 2;
                Console.Write(columnas.Substring(idxSpace - idxSpace, idxSpace) + ", ");
                string aux = columnas.Substring(idxComa - idxComa, idxComa);
                columnas = columnas.Replace(aux, "");
            }//while
            Console.WriteLine("FROM " + tabla);
        }//while
    }//Execute

    public static void Main(){
        HaciendoFacilSQL obj = new HaciendoFacilSQL();
        obj.Execute();
    }//Main
}//class HaciendoFacilSQL
