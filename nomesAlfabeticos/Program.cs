using System.Collections.Generic;
using System;

namespace nomesAlfabeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            
        
            
            List<string> alfabeto = new List<string>();
        
                for(int r =0;r <=1; r++){
                nome = Console.ReadLine();
                alfabeto.Add(nome);
                }
                Console.Clear();
                alfabeto.Sort();

                foreach (string conteudo in alfabeto)
                {
                    System.Console.WriteLine(conteudo);
                }


            


            
        }
    }
}
