using System;
using Reciclagem.interfaces;
namespace Reciclagem.Models
{
    public class GarrafaPet :IPlastico
    {
        public string ReciclarFeitoPlastico()
        {
            return this.GetType().Name;
        }
    }
}