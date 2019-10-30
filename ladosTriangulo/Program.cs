using System;

namespace ladosTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[3];
            for(int i=0;i<2;i++){
                System.Console.WriteLine($"lado{i+i}:");
                vetor[i]=int.Parse(Console.ReadLine());
                
            }
            if((vetor[0] + vetor[1] >=vetor[2]) && (vetor[0] + vetor[2] >=vetor[1]) && (vetor[1] + vetor[2] >= vetor [0]))
            {
            System.Console.WriteLine("triangulo");

            }else{
                System.Console.WriteLine("nao e triangulo");
            }
        }
    }
}
