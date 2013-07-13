using System;

class CalculateSum
{
    static void Main()
    {
        /// Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...
        Console.WriteLine("Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...");

        // Consol input
        double n = 1;
        double m = 2;

        // Consol output
        while (Math.Abs(1 / m) > 0.001)
        {
            n += 1 / m; // Calculations

            m = Math.Abs(m); // Mekes m positive to be able to increment
            m += 1;

            if (m % 2 != 0) // If value is ODD,  changes it to negative
            {
                m = -m;
            }
        }
        Console.WriteLine("{0}", n);
    }
}