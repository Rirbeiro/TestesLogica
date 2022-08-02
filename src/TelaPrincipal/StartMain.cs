using NumeroPrimo;
using System;
using TelaPrincipal.Constants;

namespace TelaPrincipal
{
    public static class StartMain
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

                string readText = Console.ReadLine();
                
                Console.Clear();

                switch (readText)
                {
                    case MainConstants.NumeroPrimo:
                        StartPrime.Main(args);
                        break;

                    case MainConstants.MovimentoBot:
                        break;

                    case MainConstants.Palindromo:
                        break;

                    default:
                        break;
                }

                Console.WriteLine($"Aperte 'ENTER' para voltar ao menu principal.{Environment.NewLine}");
                Console.ReadLine();
            }

        }
    }
}
