using System;

namespace PesoPlaneta
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double pesoPlaneta;
            double pterra;
            
            System.Console.WriteLine("digite seu peso  :");
            pterra=double.Parse(Console.ReadLine());
            System.Console.WriteLine("escolha uma opçao");
            System.Console.WriteLine("1 -seu peso em mercurio é");
            System.Console.WriteLine("2-seu peso em venus é:");
            System.Console.WriteLine("3-seu peso em mrte é");
            System.Console.WriteLine("4-seu peso em jupiter é");
            System.Console.WriteLine("5-seu peso em saturno é:");
            System.Console.WriteLine("6-seu peso em urano é:");
            pesoPlaneta=double.Parse(Console.ReadLine());
            
            switch(pesoPlaneta){
                case 1:
                System.Console.WriteLine(pesoPlaneta =(pterra/10)* 0.37);
                
                break;
                case 2:
                System.Console.WriteLine(pesoPlaneta =(pterra/10)* 0.88);
                break;
                case 3:
                System.Console.WriteLine(pesoPlaneta =(pterra/10)* 0.38);
                break;
                case 4:
                System.Console.WriteLine(pesoPlaneta =(pterra/10)* 2.64);
                break;
                case 5:
                System.Console.WriteLine(pesoPlaneta =(pterra/10)* 1.15);
                break;
                case 6:
                System.Console.WriteLine(pesoPlaneta =(pterra/10)* 1.17);
                break;
                
            }

            
        }
    }
}
