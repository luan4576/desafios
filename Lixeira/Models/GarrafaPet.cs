using System;
using Lixeira.interfaces;
namespace Lixeira.Models
{
    public class GarrafaPet :IPlastico
    {
        public bool Plastico()
        {
            System.Console.WriteLine("jogue seu plastico");
        }
    }
}