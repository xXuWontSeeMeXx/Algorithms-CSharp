using System;
using System.IO;
using System.Windows;

public class GreatestCommonDivisor{
    Vector A = new Vector();
    Vector B = new Vector();
    Vector C = new Vector();

    public void Execute(){
        StreamReader sr = new StreamReader("/home/mint/Desktop/archivo.txt");       
        string entrada;
        while((entrada = sr.ReadLine()) !=  null)
        {
            entrada = entrada.Trim();
            entrada += " ";
            string cadena = "";
            for(int i = entrada.IndexOf("A"); i < entrada.Length; ++i)
            {
                Boolean bandera = true;
                if(entrada[i] == ' ' && bandera)
                {
                    A.Add(Int32.Parse(cadena));
                    cadena = "";
                }//if
                else if(entrada[i] == ' ' && !bandera)
                {
                    B.Add(Int32.Parse(cadena));
                    cadena = "";
                }//else if
                else if(entrada[i] == 'B')
                {
                    bandera = false;
                    i++;
                }//else if
                else
                    cadena += entrada[i];
            }//for
            GetGCD();
            PrintVectores();            
        }//while
    }//Execute

    public void GetGCD(){
        for(int i = 0; i < A.Length; ++i)
        {            
            int mayor = Math.max(A[i], B[i]);
            Boolean bandera = true;
            while(bandera)
            {
                if(A[i] % mayor == 0 && B[i] % mayor == 0)
                {
                    C.Add(mayor);
                    bandera = false;
                }//if
                else
                    mayor--;
            }//while
        }//for
    }//GetGCD

    public void PrintVectores(){
        for(int i = 0; i < A.Length; ++i)
            Console.Write("A = {0}  B = {0}  C = {0}", A[i], B[i], C[i]);
        Console.WriteLine();
    }//PrintVectores
   
    public static void Main(){
        GreatestCommonDivisor obj = new GreatestCommonDivisor();
        obj.Execute();
    }//main
}//class GreatestCommonDivisor
