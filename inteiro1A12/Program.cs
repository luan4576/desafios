using System;
using System.Collections.Generic;

namespace inteiro1A12 {
    class Program {
        static void Main (string[] args) {

            Console.WriteLine ("escreva um numero de 1 a 12:");
            int a = int.Parse (Console.ReadLine ());

            
                switch (a) {
                    case 1:
                        System.Console.WriteLine ($"janeiro");
                        break;
                    case 2:
                        System.Console.WriteLine ($"fevereiro");
                        break;
                    case 3:
                        System.Console.WriteLine ($"março");
                        break;
                    case 4:
                        System.Console.WriteLine ($"abril");
                        break;
                    case 5:
                        System.Console.WriteLine ($"maio");
                        break;
                    case 6:
                        System.Console.WriteLine ($"junho");
                        break;
                    case 7:
                        System.Console.WriteLine ($"julho");
                        break;
                    case 8:
                        System.Console.WriteLine ($"agosto");
                        break;
                    case 9:
                        System.Console.WriteLine ($"setembro");
                        break;
                    case 10:
                        System.Console.WriteLine ($"outubro");
                        break;
                    case 11:
                        System.Console.WriteLine ($"novembro");
                        break;
                    case 12:
                        System.Console.WriteLine ($"dezembro");
                        break;
                }

            }

        }
    }
