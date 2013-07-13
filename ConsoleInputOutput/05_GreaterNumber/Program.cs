using System;

class GreaterNumber
{
    static void Main()
    {
        /// Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

        // Consol input
        Console.WriteLine("Enter first number");
        decimal a = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number");
        decimal b = decimal.Parse(Console.ReadLine());

        // Main Logic
        decimal result = Math.Max(a, b);

        // Consol output
        Console.WriteLine("Greater number of {0} and {1} is {2}", a, b, result);
    }
}