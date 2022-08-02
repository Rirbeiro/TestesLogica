using System;
using System.Linq;

namespace NumeroPrimo
{
    public static class InicioPrimo
    {
        const long MaxLongValue = 9223372036854775807;

        public static void Main(string[] args)
        {
            Console.WriteLine($"Entre com um número para verificar se é primo ou não:");

            string readText = Console.ReadLine();

            long.TryParse(readText, out long input);

            if (IsNumberReadText(readText))
            {
                Console.Clear();
                Console.WriteLine($"Digite somente números inteiros! {Environment.NewLine}");
                return;
            }

            if (IsMaxLongValue(readText, input))
            {
                Console.Clear();
                Console.WriteLine($"O valor máximo aceitável foi alcançado. Valor máximo é: {MaxLongValue} {Environment.NewLine}");
                return;
            }

            var (isPrime, iteration) = IsPrimeNumber(input);

            if (isPrime)
            {
                Console.WriteLine($"O número {input} é primo. Número de iterações necessárias: {iteration} {Environment.NewLine}");
            }
            else
                Console.WriteLine($"O número {input} não é primo. Número de iterações necessárias: {iteration} {Environment.NewLine}");
        }

        private static (bool isPrime, int iteration) IsPrimeNumber(long input)
        {
            int iteration = 0;

            for (int divisor = 1; divisor <= input; divisor++)
            {
                if (iteration > 2) break;
                if (input % divisor == 0) iteration++;
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
