using System;

class CalculatesSum
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN");

        int factN = 1;
        double sum = 1;

        // Consol input
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter X: ");
        int x = int.Parse(Console.ReadLine());

        // Main Logic
        for (int i = 1; i < n; i++)
        {
            factN *= i;
			sum += factN/Math.Pow(x,i);
        }

        // Consol Output
        Console.WriteLine("Result is: {0}", sum);
    }
}

