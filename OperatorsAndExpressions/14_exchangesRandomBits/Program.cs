using System;

class ExchangesRandomBits
{
    static void Main()
    {
        /// * Write a program that exchanges bits {p, p+1, …, p+k-1)
        /// with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.
        
        /// You need the count of the Bits and the position of the first bit(left to right) for both sequences

        // Given number
        int number = 50332264;

        // First Sequence {p, p+1, …, p+k-1} 
        int countfBits = 3;

        int positionFirstBit = 2;
        int maskFirstSequence = ((2 * countfBits + 1) << positionFirstBit); // 2n+1 -> 001, 011, 111, ...

        // Second Sequence {q, q+1, …, q+k-1} 
        int positionSecondBit = 6;
        int maskSecondSequence = ((2 * countfBits + 1) << positionSecondBit); // 2n+1 -> 001, 011, 111, ...		

        // placeHolder - The given number with 0 for both sequences that will be exchanged
        int maskPlaceHolder = ~(maskSecondSequence | maskFirstSequence); // 11111100011111111111111111000111
        int placeHolder = number & maskPlaceHolder;

        // Exchanges the positons of both  sequences
        int movedFirstSequence = ((number & maskFirstSequence) << (positionSecondBit - positionFirstBit));
        int movedSecondSequence = ((number & maskSecondSequence) >> (positionSecondBit - positionFirstBit));

        //int newNumber = (placeHolder | ((number & maskFirstSequence) << (positionSecondBit - positionFirstBit))) | ((number & maskSecondSequence) >> (positionSecondBit - positionFirstBit));
        int newNumber = (placeHolder | movedFirstSequence) | movedSecondSequence;

        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine(Convert.ToString(maskFirstSequence, 2).PadLeft(32, '0'));
        Console.WriteLine(Convert.ToString(maskSecondSequence, 2).PadLeft(32, '0'));
        Console.WriteLine(Convert.ToString(maskPlaceHolder, 2).PadLeft(32, '0'));
        Console.WriteLine(Convert.ToString(placeHolder, 2).PadLeft(32, '0'));
        Console.WriteLine(Convert.ToString(newNumber, 2).PadLeft(32, '0'));
    }
}