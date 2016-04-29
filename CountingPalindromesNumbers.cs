using System;
using System.IO;

public class CountingPalindromesNumbers{
    public void Execute(){
        StreamReader sr = new StreamReader("archivo.txt");
        string entrada;
        while((entrada = sr.ReadLine()) != null)
        {
            int digitos = Int32.Parse(entrada);
            int limite = GetLimite(digitos);
            Console.WriteLine(GetCounting(limite));
        }//while
    }//Execute

    public int GetLimite(int digitos){
        string limite = "";
        for(int i = 0; i < digitos; ++i)
            limite += "9";
        return Int32.Parse(limite);
    }//GetLimite

    public int GetCounting(int limite){
        int conteo = 0;
        for(int i = 0; i <= limite; ++i)
            conteo += ComparaDigito(i + "");
        return conteo;
    }//GetCounting

    public int ComparaDigito(string num){
        string aux = num;
        int counting = 0;
        num = "";
        for(int i = aux.Length - 1; i >= 0; --i)
            num += aux[i];
        if(aux.Equals(num))
            counting = 1;
        return counting;
    }//ComparaDigito

    public static void Main(){
        CountingPalindromesNumbers obj = new CountingPalindromesNumbers();
        obj.Execute();
    }//Main
}//class CountingPalindromesNumbers
