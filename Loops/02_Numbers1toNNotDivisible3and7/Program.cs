using System;
using System.Collections.Generic;

class Numbers1toNNotDivisible3and7
{
    static void Main(string[] args)
    {
        /// Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.
        Console.WriteLine("Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.");

        // Consol input
        Console.Write("Enter N bigger than 21: ");
        uint n = uint.Parse(Console.ReadLine());

        // Main logic
        if (n <= 21) 
        {
            Console.WriteLine("Please, enter N bigger than 21");
        }
        else
        {
            List<uint> numbers = new List<uint>(); 

            for (uint i = 22; i <= n; i++)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    numbers.Add(i);
                }
            }

            // Consol output
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}

