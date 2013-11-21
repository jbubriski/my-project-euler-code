using System;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 13195;
            var maxPrime = (number - 1) / 2;

            while (true)
            {
                var prime = true;

                for (var i = 2; i < maxPrime; i++)
                {
                    if (maxPrime % i == 0)
                    {
                        prime = false;
                        break;
                    }
                }

                if (prime)
                {
                    Console.WriteLine("The largest prime of {0} is {1}", number, maxPrime);
                    break;
                }

                maxPrime--;
            }

            Console.ReadKey();
        }
    }
}
