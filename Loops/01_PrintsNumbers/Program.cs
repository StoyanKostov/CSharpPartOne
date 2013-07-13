using System;

class PrintsNumbers
{
    static void Main(string[] args)
    {
        /// Write a program that prints all the numbers from 1 to N.
        Console.WriteLine("Write a program that prints all the numbers from 1 to N.");

        // Consol input
        Console.Write("Enter N: ");
        uint n = uint.Parse(Console.ReadLine());

        // Main logic
        uint[] members = new uint[n];
        
        for (uint i = 0; i < n; i++)
        {
            members[i] = i+1;
        }

        // Consol output
        Console.WriteLine(string.Join(", ", members));
    }
}

