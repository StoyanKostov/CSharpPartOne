using System;

class FactDiv
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write a program that calculates N!/K! for given N and K (1<K<N).");

        uint result = 1;

        // Consol input
        Console.Write("Enter N: ");
        uint n = uint.Parse(Console.ReadLine());

        Console.Write("Enter K: ");
        uint k = uint.Parse(Console.ReadLine());

        while (k > n)
        {
            result *= k;
            k--;
        }

        Console.WriteLine("Result is: {0}", result);

    }
}

