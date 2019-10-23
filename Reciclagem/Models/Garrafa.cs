using System;
using Reciclagem.interfaces;
namespace Reciclagem.Models

{
    public class Garrafa : IVidro
    {
        public string ReciclarFeitoVidro()
        {
            return this.GetType().Name;
        }
    }
}