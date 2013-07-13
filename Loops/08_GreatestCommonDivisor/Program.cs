using System;

class GreatestCommonDivisor
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write a program that calculates the greatest common divisor (GCD) of given two numbers. Use the Euclidean algorithm (find it in Internet).");

        int temp;

        // Consol input
        Console.Write("Enter first number a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter second number b: ");
        int b = int.Parse(Console.ReadLine());

        // Main logic

        if (a < b) // Exchange values 
        {
            b = a + b;
            a = b - a;
            b = b - a;
        }

        else
        {
            while (a % b != 0)
            {
                temp = a % b;
                a = b;
                b = temp;
            }
        }

        // Consol output
        Console.WriteLine("Result: {0}", b);
    }
}

