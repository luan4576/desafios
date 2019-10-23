using System;
using Reciclagem.interfaces;
namespace Reciclagem.Models
{
    public class Papelao :IPapel
    {
        public string ReciclarFeitoPapel()
        {
            return this.GetType().Name;
        }
    }
}