﻿using System.Collections.Generic;
using System;

namespace numerosCrescentes {
    class Program {
        static void Main (string[] args) {
            int i = 0;
            List<int> _lista = new List<int> ();

            while (i <= 2) {

                Console.WriteLine ("Digite seu " + (i + 1) + "º número");
                _lista.Add (int.Parse (Console.ReadLine ()));

                i++;
            }
            // Aqui voce ordena e inverte a ordem
            _lista.Sort ();
            _lista.Reverse ();

            Console.WriteLine ();
            Console.WriteLine ("Os numeros digitados são:");

            foreach (int termo in _lista) {
                Console.WriteLine (termo);
            }
            Console.ReadKey ();
        }
    }
}
