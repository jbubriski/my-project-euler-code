using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("99");
            Console.WriteLine(FindPalindrome(99));

            Console.WriteLine();
            Console.WriteLine("999");
            Console.WriteLine(FindPalindrome(999));

            Console.ReadKey();
        }

        private static int FindPalindrome(int max)
        {
            var originalMax = max;
            var number = 0;

            var currentBest = 0;

            while (originalMax > 0)
            {
                number = originalMax * max;

                if (IsPalindrome(number))
                {
                    if (number > currentBest)
                    {
                        currentBest = number;
                    }
                }

                max--;

                if (max == 0)
                {
                    max = originalMax;
                    originalMax--;
                }
            }

            return currentBest;
        }

        private static bool IsPalindrome(int number)
        {
            var numberString = number.ToString();

            for (int i = 0; i < numberString.Length / 2; i++)
            {
                if (numberString[i] != numberString[numberString.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
