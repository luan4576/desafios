using System.Collections.Generic;

namespace zoologico.Models
{
    public class zoo
    {
        public static Dictionary<int, Animal> animais = new Dictionary<int, Animal>() {
            {1, new Arara()},
            {2, new chimpaze()},
            {3, new Golfinho()},
            {4, new Leao()},
            {5, new Orangotango()},
            {6, new Tartaruga()},
            {7, new TubaraoMartelo() },
            {8, new Tucano()}
            };
}
}
