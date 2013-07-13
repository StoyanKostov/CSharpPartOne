using System;

class NumbersInInterval
{
    static void Main()
    {
        /// Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.
        Console.WriteLine("Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.");

        // Consol input
        Console.WriteLine("Enter number");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(" ");

        if (n <= 0)
        {
            Console.WriteLine("Enter positive number bigger than 0");
            return;
        }

        // Consol output
        while (n > 0)
        {
           Console.WriteLine("{0}", n);
           n -= 1;
        }
    }
}