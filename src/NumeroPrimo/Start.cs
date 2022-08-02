using System;
using System.Linq;

namespace NumeroPrimo
{
    public static class Start
    {
        const long MaxLongValue = 9223372036854775807;

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine($"Entre com um número para verificar se é primo ou não:");

                string readText = Console.ReadLine();

                long.TryParse(readText, out long input);

                if (IsNumberReadText(readText))
                {
                    Console.Clear();
                    Console.WriteLine($"Digite somente números inteiros! {Environment.NewLine}");
                    continue;
                }

                if (IsMaxLongValue(readText, input))
                {
                    Console.Clear();
                    Console.WriteLine($"O valor máximo aceitável foi alcançado. Valor máximo é: {MaxLongValue} {Environment.NewLine}");
                    continue;
                }

                var (isPrime, iteration) = IsPrimeNumber(input);

                if (isPrime)
                {
                    Console.WriteLine($"O número {input} é primo. Número de iterações necessárias: {iteration} {Environment.NewLine}");
                }
                else
                    Console.WriteLine($"O número {input} não é primo. Número de iterações necessárias: {iteration} {Environment.NewLine}");
            }
        }

        public static (bool isPrime, int iteration) IsPrimeNumber(long input)
        {
            int iteration = 0;

            for (int i = 1; i <= input; i++)
            {
                if (iteration > 2) break;
                if (input % i == 0) iteration++;
            }

            Console.Clear();

            if (iteration == 2) { return (true, iteration); }
            else { return (false, iteration); }
        }

        private static bool IsMaxLongValue(string readText, long value) =>
            readText != null && readText.All(char.IsDigit) && value == 0;

        private static bool IsNumberReadText(string readText) =>
            !readText.All(char.IsDigit);
    }
}
