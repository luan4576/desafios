using System;
using Lixeira.interfaces;
namespace Lixeira.Models
{
    public class Papelao :IPapel
    {
        public bool Papel()
        {
            System.Console.WriteLine("jogue seu papel");
        }
    }
}