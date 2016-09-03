/*
 *    Bruce Wayne is known as BATMAN and a nocturnal peculiar mammal represents him; the word of that
 *    animal in Spanish consists of 5 consonants and the 5 vowels, from which none of them is repeated. This
 *    word must create an encryption code to transfer text files. These are the following rules:
 *    
 *    0
 *    1
 *    2
 *    3
 *    4
 *    5
 *    6
 *    7
 *    8
 *    9
 *
 *    Each letter of the mysterious word (animal’s name in Spanish) will become a number (0 to 9) and at the
 *    beginning of each word placed in the file should precede the indicator of the length of each word in byte
 *    format. The program must take a text file (WITH WORDS ONLY, NOT NUMBERS) as input and generate
 *    an output file.
 *
 *    The following example is shown for better comprehension:
 *
 *    Input
 *
 *        File name: TEXT.txt containing the following text:
 *
 *        HOLA
 *        QUIERO CONTARTE UN SECRETO
 *
 *    Output
 *
 *        File name: TEXT.crp (Encrypted)
 *
 *        (BYTE 4)H967
 *        (BYTE 6)Q14529(BYTE 8)39NT72T5(BYTE 2)1N(BYTE 7)S5325T0
 */

using System;
using System.IO;

public class Batcode{
    public void Execute(){
        StreamReader sr = new StreamReader("archivo.txt");
        string entrada;
        while((entrada = sr.ReadLine()) != null)
        {
            entrada = entrada.ToUpper().Trim();
            entrada += " ";
            string cadena = "";
            for(int i = 0; i < entrada.Length; ++i)
            {
                if(entrada[i] == ' ')
                {
                    string crypt = cryptCadena(cadena);
                    Console.Write(crypt);
                    cadena = "";
                }//if
                else
                    cadena += entrada[i];
            }//for
            Console.WriteLine();
        }//while
    }//Execute

    public string cryptCadena(string cadena){
        const string KEYWORD = "MURCIELAGO";
        const string DIGITS  = "0123456789";
        string strBytes = "(BYTE " + cadena.Length + ")";
        for(int i = 0; i < cadena.Length; ++i)
        {
            for(int j = 0; j < KEYWORD.Length; ++j)
                if(cadena[i] == KEYWORD[j])
                    cadena = cadena.Replace(cadena[i], DIGITS[j]);
        }//for
        strBytes += cadena;
        return strBytes;
    }//cryptCadena

    public static void Main(){
        Batcode obj = new Batcode();
        obj.Execute();
    }//Main
}//Batcode
