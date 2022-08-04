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

            try
            {
                Console.WriteLine("Entre com uma palavra ou texto.");
                string inputNoFilter = Console.ReadLine().ToUpper();

                char[] input = new String(inputNoFilter.Where(Char.IsLetter).ToArray()).ToCharArray();

                for (int start = 0, end = input.Length - 1; start < end; start++, end--)
                {
                    if (input[start] != input[end])
                    {
                        isPalindrome = false;
                        break;
                    }
                }
            }
            catch
            {
                return false;
            }

            return isPalindrome;
        }
    }
}
