using System;

class TriangleSymbols
{
    static void Main()
    {
        /// Write a program that prints an isosceles triangle of 9 copyright symbols ©. Use Windows Character 
        /// Map to find the Unicode code of the © symbol. Note: the © symbol may be displayed incorrectly.
        char copyrightSymbol = '\u00A9';

        int i = 3; // rows
        int j = 0; // number of sybbols per row
        int g = 5; // third number (there are 3 rows) of the sequence n + 2 or 3 + 2 = 5
        int f = 2; // number of empty spaces for each row

        while (i > 0)
        {
            while (j < g)
            {
                Console.Write(copyrightSymbol);
                j += 1;
            }

            Console.WriteLine(" ");

            while (f < i)
            {
                Console.Write(" ");
                f += 1;
            }

            g -= 2; // decrement by the step of the sequence n + 2
            i -= 1; // decrement nember rows
            j = 0;
            f -= 3;
        }
    }
}