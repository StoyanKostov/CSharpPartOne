using System;

class ReminderDivisionBy5is0
{
    static void Main()
    {
        /// Write a program that reads two positive integer numbers and prints how many numbers p 
        /// exist between them such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.

        // Consol input
        Console.WriteLine("Enter first positiv integer");
        uint a = uint.Parse(Console.ReadLine());

        Console.WriteLine("Enter second positiv integer");
        uint b = uint.Parse(Console.ReadLine());

        // Main Logic
        int counter = 0;

        for (uint i = a; i <= b; i++)
        {
            if (i % 5 == 0)
            {
                counter += 1; 
            }
        }

        // Consol output
        Console.WriteLine("p({0},{1}) = {2}", a, b, counter);
    }
}