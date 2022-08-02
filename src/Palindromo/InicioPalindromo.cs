using System;
using System.Linq;

namespace Palindromo
{
    public static class InicioPalindromo
    {
        public static void Main(string[] args)
        {
            var isPalindrome = Palindrome();

            string output = isPalindrome ? "Entrada é um políndromo." : "Entrada não é um políndromo.";

            Console.WriteLine(output + Environment.NewLine);
        }

        public static bool Palindrome()
        {
            bool isPalindrome = true;

            Console.WriteLine("Entre com uma palavra ou texto.");
            string inputNoFilter = Console.ReadLine().ToUpper();

            char[] input = new String(inputNoFilter.Where(Char.IsLetter).ToArray()).ToCharArray();

            for (int i = 0, j = input.Length - 1; i < j; i++, j--)
            {
                if (input[i] != input[j])
                {
                    isPalindrome = false;
                    break;
                }
            }

            return isPalindrome;
        }
    }
}
