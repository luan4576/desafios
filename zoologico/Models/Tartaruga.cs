using zoologico.interfaces;

namespace zoologico.Models
{
    public class Tartaruga : zoo, IAquario
    {
        public string Nadar ()
        {
            return this.GetType().Name;
        }
    }
}