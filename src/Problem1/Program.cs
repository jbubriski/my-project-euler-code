﻿using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;

            for (var i = 0; i < 10; i++)
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;

            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}