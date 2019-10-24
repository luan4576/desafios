using System;

namespace temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int f ;
            System.Console.WriteLine("digite a temperatura :");
            int c =int.Parse( Console.ReadLine());
            
            f = (c*9) / 5 + 32;
            System.Console.WriteLine("a temperatura em fahrenheit é:"+ f );
        }
    }
}
