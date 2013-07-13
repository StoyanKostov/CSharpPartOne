using System;
using System.Collections.Generic;

class SequenceFibonacci
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …");

        List<uint> members = new List<uint> {0};
        uint a = 1;
        uint b = 0;
        uint sum = 0;

        // Consol input
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        // Main Logic
        for (int i = 1; i < n; i++)
        {
            b = b + a;
            a = b - a;

            sum += b;
            members.Add(b);
        }

        // Consol Output
        Console.WriteLine(string.Join(", ", members));
        Console.WriteLine("Result is: {0}", sum);
    }
}

