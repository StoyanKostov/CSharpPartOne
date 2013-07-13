using System;

class SetBit
{
    static void Main()
    {
        /// We are given integer number n, value v (v=0 or 1) and a position p. Write a sequence of operators that
        /// modifies n to hold the value v at the position p from the binary representation of n.
        /// Example: n = 5 (00000101), p=3, v=1 -> 13 (00001101)	n = 5 (00000101), p=2, v=0 -> 1 (00000001)

        // Given number
        int number = 608;

        // Bit position counted from 0
        byte p = 5;

        // Bit value (v=0 or 1)
        byte v = 0;

        int mask = 0;
        int numberAndMask = 0;


        if (v == 0)
        {
            mask = ~(1 << p);
            numberAndMask = number & mask;
        }
        else
        {
            mask = 1 << p;
            numberAndMask = number | mask;
        }

        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine(Convert.ToString(numberAndMask, 2).PadLeft(32, '0'));

    }
}