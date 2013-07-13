using System;

class HexValue
{
    static void Main()
    {
        /// Declare an integer variable and assign it with the  
        /// value 254 in hexadecimal format. Use Windows 
        /// Calculator to find its hexadecimal representation.
        int value254 = 0xFE;

        // Convert integer as a hex in a string variable
        string hexValue = value254.ToString("X");

        Console.WriteLine(
            "The value of integer 254 in hexadecimal representation if equal: 0x{0}",
            hexValue);
    }
}