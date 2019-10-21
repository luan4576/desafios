using System;
using Lixeira.interfaces;
namespace Lixeira.Models

{
    public class Garrafa : IVidro
    {
        public bool Vidro()
        {
            System.Console.WriteLine("jogue seu vidro");
        }
    }
}