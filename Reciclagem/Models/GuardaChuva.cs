using System;
using Reciclagem.interfaces;
namespace Reciclagem.Models
{
    public class GuardaChuva : IIndefinido
    {
        public string ProcurarOQueFazer()
        {
            return this.GetType().Name;
        }
    }
}