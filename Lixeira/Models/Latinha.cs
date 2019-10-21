using System;
using Lixeira.interfaces;
namespace Lixeira.Models
{
    public class Latinha : IMetal
    {
        public bool Metal()
        {
        System.Console.WriteLine("jogue seu metal aqui");
        }
    }
}