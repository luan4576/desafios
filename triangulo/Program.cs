using System;

namespace triangulo
{
    class Program
    {
        static void Main(string[] args)
        {

            int a,b,c,d;
            System.Console.WriteLine("digite a altura do triangulo");
                a = int.Parse(Console.ReadLine());

                for(b=1;b<=a;b++)
                {
                    for(c=1;c<b;c++)
                {
                    System.Console.Write("");
                }
                for(d=0;d<((a-b+1)*2) - 1;d++)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine();
                }
            Console.ReadKey();
            

            
        }
    }
}
