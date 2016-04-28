using System;
using System.IO;

public class Chairs{
    public void Execute(){
        StreamReader sr = new StreamReader("C:\\Users\\PC11-104.CUTONALA\\Downloads\\archivo.txt");
        string entrada;
        while((entrada = br.ReadLine()) != null)
        {
            int m = Int32.parse(entrada);
            if(m == 1)
                Console.WriteLine(0);
            else{
                int notUsed = 0;
                for(int i = 0; i < m - 1; ++i)
                    notUsed += 2;
                Console.WriteLine(notUsed);
            }//else
        }//while
    }//Execute

    public static void Main(){
        Chairs obj = new Chairs();
        obj.Execute();
    }//Main
}//class Chairs
