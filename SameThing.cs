using System;
using System.IO;

public class SameThing{
    public void Execute(){
        StreamReader sr = new StreamReader("/home/mint/Desktop/archivo.txt");
        string entrada;
        while((entrada = sr.ReadLine()) != null)
        {
            int index = entrada.IndexOf(".");
            string cadena1 = entrada.Substring(0, index);
            string cadena2 = entrada.Substring(index + 1);
            Console.WriteLine(ProcesaCadenas(cadena1, cadena2));
        }//while
    }//Execute

    public int ProcesaCadenas(string cadena1, string cadena2){
        int salida = 0;
        if(cadena1.Equals(cadena2))
            salida = 1;
        else{
            string aux = "";
            for(int i = cadena2.Length - 1; i >= 0; --i)
                aux += cadena2[i];
            if(cadena1.Equals(aux))
                salida = 1;
        }//else
        return salida;
    }//ProcesaCadenas

    public static void Main(){
        SameThing obj = new SameThing();
        obj.Execute();
    }//Main
}//class SameThing
