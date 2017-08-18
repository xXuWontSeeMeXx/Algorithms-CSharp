using System;
using System.IO;

public class TheFaLanguage{
	public static void Main(){
		StreamReader sr = new StreamReader("archivo.txt");
		string entrada;
		while((entrada = sr.ReadLine()) != null)
		{
			for(int i = 0; i < entrada.Length; i++)
			{
				Console.Write(entrada[i]);
				try{
					bool isVowel = (entrada[i] == 'a' || entrada[i] == 'e' || entrada[i] == 'i' || entrada[i] == 'o' || entrada[i] == 'u' || 
							   	    entrada[i] == 'A' || entrada[i] == 'E' || entrada[i] == 'I' || entrada[i] == 'O' || entrada[i] == 'U');
					bool isNextVowel = (entrada[i + 1] == 'a' || entrada[i + 1] == 'e' || entrada[i + 1] == 'i' || entrada[i + 1] == 'o' || entrada[i + 1] == 'u' || 
							           entrada[i + 1] == 'A' || entrada[i + 1] == 'E' || entrada[i + 1] == 'I' || entrada[i + 1] == 'O' || entrada[i + 1] == 'U');
					if(isVowel && !isNextVowel)
						Console.Write("f" + entrada[i]);
				}catch(IndexOutOfRangeException str){}
			}//for
			Console.WriteLine();
		}//while
	}//main
}//class TheFaLanguage
