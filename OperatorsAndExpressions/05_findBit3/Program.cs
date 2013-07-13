using System;

class FindBit3
{
    static void Main()
    {
        /// Write a boolean expression for finding if the bit 3
        /// (counting from 0) of a given integer is 1 or 0.
        int value = 4;
        int p = 2;
        int mask = 1 << p;
        int valueAndMask = value & mask;
        int bit = valueAndMask >> p;

        Console.WriteLine("The 3th bit of {0} is: {1}", value, Convert.ToString(bit, 2));
    }
}