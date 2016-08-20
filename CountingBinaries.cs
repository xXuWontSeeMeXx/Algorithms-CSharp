using System;
using System.IO;

public class CountingBinaries{
    public void Execute(){
        StreamReader sr = new StreamReader("archivo.txt");
        string entrada;
        while((entrada = sr.ReadLine()) != null)
        {
            entrada = entrada.Trim();
            int num = Int32.Parse(entrada);
            int counting = 0;
            for(int i = 1; i <= num; ++i)
            {
                string binario = Convert.ToString(i, 2);
                counting += CountUnos(binario);
            }//for
            Console.WriteLine(counting);
        }//while
    }//Execute

    public int CountUnos(string cadena){
        int sum = 0;
        for(int i = 0; i < cadena.Length; ++i)
            if(cadena[i] == '1')
                sum++;
        return sum;
    }//CountUnos

    public static void Main(){
        CountingBinaries obj = new CountingBinaries();
        obj.Execute();
    }//Main
}//class CountingBinaries
