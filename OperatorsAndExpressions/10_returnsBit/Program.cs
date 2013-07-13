using System;

class ReturnsBit
{
    static void Main()
    {
        /// Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer 
        /// number v has value of 1. Example: v=5; p=1 ? false.

        // Given number
        int number = 608;

        // Bit position counted from 0
        int p = 7;

        // Bit mask
        int mask = 1 << p;
        int numberAndMask = number & mask;
        int bit = (numberAndMask >> p);
        bool result = bit == 1;

        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine("The {0}th bit of {1} has the value of 1: {2}", p, number, result);
    }
}