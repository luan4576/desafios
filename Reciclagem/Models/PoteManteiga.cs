using System;
using Reciclagem.interfaces;
namespace Reciclagem.Models
{
    public class PoteManteiga : IIndefinido
    {
        public string ProcurarOQueFazer()
        {
            return this.GetType().Name;
        }
    }
}