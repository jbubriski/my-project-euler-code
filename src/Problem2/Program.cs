using System;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            var previousterm = 1;
            var previousterm2 = 0;

            while(true)
            {
                if (previousterm % 2 == 0)
                    sum += previousterm;

                if (previousterm > 4000000)
                    break;

                var newTerm = previousterm + previousterm2;

                previousterm2 = previousterm;
                previousterm = newTerm;

                Console.WriteLine(previousterm);
            }

            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
