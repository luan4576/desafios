using System;
using Lixeira.interfaces;
namespace Lixeira.Models
{
    public class Comida : IOrganico
    {
        public bool Organico()
        {
            System.Console.WriteLine("jogue restos de comida");
        }
    }
}