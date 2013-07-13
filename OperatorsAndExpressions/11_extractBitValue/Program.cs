using System;

class extractBitValue
{
    static void Main()
    {
        /// Write an expression that extracts from a given integer i the value of a given bit number b. 
        /// Example: i=5; b=2 -> value=1.

        // Given number
        int number = 608;

        // Bit position counted from 0
        int p = 5;

        // Bit mask
        int mask = 1 << p;
        int numberAndMask = number & mask;
        int bit = (numberAndMask >> p);

        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine("The {0}th bit of {1} is: {2}", p, number, bit);
    }
}