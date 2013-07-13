using System;

class SequenceFibonacci
{
    static void Main()
    {
        /// Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
        Console.WriteLine("Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …");

        decimal number = 0;
        decimal nextNumber = 1;
        
        // Consol output
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine("{0}", number);
            number = number + nextNumber;
            nextNumber = number - nextNumber;    
        }
    }
}