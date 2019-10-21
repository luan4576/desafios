using System;

namespace Lixeira
{

    enum LixeiraEnum : uint
    {
        Comida,
        Garrafa,
        GarrafaPet,
        Latinha,
        Merda,
        Papelao
    }

    enum CategoriaEnum : uint
    {
        Metal,
        NaoReciclavel,
        Organico,
        Papel,
        Plastico,
        Vidro

    }
    class Program
    {
        static void Main(string[] args)
        {
            bool quersair = false;
            string [] itensMenuCategoria = Enum.GetNames(typeof(CategoriaEnum));

            var opcoesFormacao = new List<string>() {

                "   - 0                         ",
                "   - 1                         ",
            };

                int opcaoLixeiraSelecionada = 0;

                string menuBar = "==================================";
                do
                {
                    Console.Clear();
                    
                    System.Console.WriteLine(menuBar);
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    System.Console.WriteLine("========================");
                    System.Console.WriteLine("      RECICLAGEM        ");
                    System.Console.WriteLine("========================");
                    System.Console.WriteLine(" Seja bem-vindo(a) pessoa!      ");
                    System.Console.WriteLine("Escolha uma uma opçao para descartar seu lixo");
                    Console.ResetColor();
                    System.Console.WriteLine(menuBar);

                    #region Troca a cor do item do menu.
                    for (int i = 0; i < opcoesFormacao.Count; i++)
                    {
                        string titulo = TratarTituloMenu(itensMenuPrincipal[i]);

                        if (opcaoLixeiraSelecionada == i)
                        {
                            DestacarOpcao(opcoesFormacao[opcaoLixeiraSelecionada].Replace("-", ">").Replace(i.ToString(), titulo));
                        }
                        else
                        {
                            System.Console.WriteLine(opcoesFormacao[i].Replace(i.ToString(), titulo));
                        }
                    }
                    #endregion


                    #region  le a tecla precionada pelo usuario e verifica a opçao selecionada 
                    var key = Console.ReadKey(true).Key;

                    switch (opcaoLixeiraSelecionada)
                    {
                        case
                    }
                }
            }
        }
    }

