using System;

namespace VariaveisA_B
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            System.Console.WriteLine("digite um valor de A:");
            a =int.Parse(Console.ReadLine());
            
            System.Console.WriteLine("digite o valor de B");
            b=int.Parse(Console.ReadLine());

            b=a-b;
            a=a-b;
            b=a+b;

            System.Console.WriteLine("valor de A e:"+a+"valor de B é :" +b);
            
        }
    }
}
