using System;

class ExchangesBits
{
    static void Main()
    {
        /// Write a program that exchanges bits 3, 4 and 5 with 
        /// bits 24, 25 and 26 of given 32-bit unsigned integer.

        // Given number
        uint number = 50332264; // 00000011000000000000001001101000

        // takes 3, 4 and 5 bits and moves them to new positon 24, 25 and 26
        uint maskLeft = 56; // 00000000000000000000000000111000
        uint moveBitsLeft = (number & maskLeft) << 20;

        // takes 24, 25 and 26 bits and moves them to new positon 3, 4 and 5
        uint maskRight = maskLeft << 20; // 00000011100000000000000000000000
        uint moveBitsRight = (number & maskRight) >> 20;

        // Put 0 to 3, 4, 5, 24, 25 and 26 bits
        uint maskPlaceHolder = ~(maskLeft | maskRight); // 11111100011111111111111111000111
        uint placeHolder = number & maskPlaceHolder;

        // Exchanges the bits 
        uint newNumber = (placeHolder | moveBitsLeft) | moveBitsRight;

        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine(Convert.ToString(moveBitsLeft, 2).PadLeft(32, '0'));
        Console.WriteLine(Convert.ToString(moveBitsRight, 2).PadLeft(32, '0'));
        Console.WriteLine(Convert.ToString(newNumber, 2).PadLeft(32, '0'));
    }
}