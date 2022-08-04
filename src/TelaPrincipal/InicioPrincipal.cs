using MovimentoBot;
using NumeroPrimo;
using Palindromo;
using System;
using TelaPrincipal.Constants;

namespace TelaPrincipal
{
    public static class InicioPrincipal
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine($"Qual teste de lógica deseja verificar?{Environment.NewLine}");

                Console.WriteLine($"1 - Número primo?{Environment.NewLine}");

                Console.WriteLine($"2 - Movimento do bot?{Environment.NewLine}");

                Console.WriteLine($"3 - Palíndromo?{Environment.NewLine}");

                Console.WriteLine($"Enter - Sair?{Environment.NewLine}");

                string readText = Console.ReadLine();
                
                Console.Clear();

                switch (readText)
                {
                    case MainConstants.NumeroPrimo:
                        InicioPrimo.Main(args);
                        break;

                    case MainConstants.MovimentoBot:
                        InicioBot.Main(args);
                        break;

                    case MainConstants.Palindromo:
                        InicioPalindromo.Main(args);
                        break;

                    default:
                        Environment.Exit(0);
                        break;
                }

                Console.WriteLine($"Aperte 'ENTER' para voltar ao menu principal.{Environment.NewLine}");
                Console.ReadLine();
            }

        }
    }
}
