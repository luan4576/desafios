using System;
using Lixeira.interfaces;
namespace Lixeira.Models
{
    public class Merda : INaoReciclavel
    {
        public bool Naoreciclavel()
        {
            System.Console.WriteLine("qualquer merda nao reciclavel");
        }
    }
}