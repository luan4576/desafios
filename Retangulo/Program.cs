using System;

namespace Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("digite a altura do retangulo");
            double a = double.Parse(Console.ReadLine());
            
            System.Console.WriteLine("digite a base do retangulo");
            double b = double.Parse(Console.ReadLine());
            
            
            double perimetro = ((a*2)+ (b*2));
            double diagonal = ((a*b)/2);
            double area = (a*b);
            System.Console.WriteLine("perimetro:" + perimetro+ "diagonal"+ diagonal+ "area"+area);            


        }
    }
            
}

