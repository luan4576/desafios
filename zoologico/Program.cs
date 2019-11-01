using System;

namespace zoologico
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            var  nomesd ;
            
            System.Console.WriteLine("animais disponiveis:");
            System.Console.WriteLine("1-tubarao martelo");
            System.Console.WriteLine("2-tucano");
            System.Console.WriteLine("3-arara");
            System.Console.WriteLine("4-leao");
            System.Console.WriteLine("5-orangotango");
            System.Console.WriteLine("6-chimpazé");
            System.Console.WriteLine("7-pinguim");
            System.Console.WriteLine("8-tartaruga");
            System.Console.WriteLine("9-golfinho");
            System.Console.WriteLine("digite um numero ou nome do animal ");
            nomesd=int.Parse(Console.ReadLine());
            
            

        




            switch(nomesd){
                case 1:
                System.Console.WriteLine($"pasto");
                break;
                case 2:System.Console.WriteLine($"gaiola");
                break;
                case 3:System.Console.WriteLine($"casa na arvore");
                break;
                case 4:System.Console.WriteLine($"caverna de pedra");
                break;
                case 5:System.Console.WriteLine($"piscina gelada");
                break;
                case 6:System.Console.WriteLine($"piscina");
                break;
                case 7:System.Console.WriteLine($"aquario");
                break;
                
            }

        
    }
}
}
