using System;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("13195 -> ");
            Console.WriteLine(CalculateBiggestPrime(13195));

            Console.WriteLine();
            Console.WriteLine("600851475143 -> ");
            Console.WriteLine(CalculateBiggestPrime(600851475143));

            Console.ReadKey();
        }

        private static Int64 CalculateBiggestPrime(Int64 number)
        {
            var i = 2;
            var maybePrime = new Int64();

            while (true)
            {
                if (number % i == 0)
                {
                    maybePrime = number / i;

                    if (IsPrime(maybePrime))
                    {
                        break;
                    }
                }

                i++;
            }

            return maybePrime;
        }

        private static bool IsPrime(Int64 number)
        {
            var half = number / 2;

            for (int i = 2; i < half; i++)
            {
                if (number % i == 0)
                {
                    // Not a prime
                    return false;
                }
            }

            return true;
        }
    }
}
