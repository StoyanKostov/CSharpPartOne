using System;

class CatalanNumbers
{
    // Help function
    static int Factorial(int number)
    {
        for (int i = (number - 1); i > 0; i--)
        {
            number = number * i;
        }
        return number;
    }
    
    static void Main(string[] args)
    {
        Console.WriteLine("Write a program to calculate the Nth Catalan number by given N.");

        int result;

        // Consol input
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        // Main logic
        result = Factorial(2 * n) / (Factorial(n + 1) * Factorial(n));

        // Consol output
        Console.WriteLine("Nth Catalan number by given {0} is {1}", n, result);
    }
}

