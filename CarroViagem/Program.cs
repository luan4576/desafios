using System;

namespace CarroViagem
{
    class Program
    {
        static void Main(string[] args)
        {
            int distancia;
            System.Console.WriteLine("digite o tempo gasto");
            int tempo=int.Parse ( Console.ReadLine());
        
            System.Console.WriteLine("qual a velocidade media ");
            int velocidade=int.Parse(Console.ReadLine());
            

            distancia=tempo*velocidade;
            int litrosUsados = distancia/12;

            System.Console.WriteLine("velocidade media:"+velocidade+"tempo gasto na viajem"+tempo+"litros usados na viajem"+litrosUsados);
            
        }
    }
}
