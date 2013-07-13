using System;

class CalculatesSum
{
    static void Main()
    {
        /// Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 
        Console.WriteLine("Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum.");

        decimal result = 0;

        // Consol output
        while (true)
        {
            Console.WriteLine("Enter number");
            decimal n = decimal.Parse(Console.ReadLine());
            result += n;
            Console.WriteLine("Current sum is = {0}", result);
        }
    }
}