using System;
using System.Text;

class ASCIITable
{
    static void Main()
    {
        /// Find online more information about ASCII (American Standard Code for Information 
        /// Interchange) and write a program that prints the entire ASCII table of characters on the console.
        Console.OutputEncoding = Encoding.Unicode;
        for (int numRep = 0; numRep <= 255; numRep++) // numRep is  numerical representation of a character
        {
            Console.WriteLine("ASCII symbol {0} and its Dec {1}", (char)numRep, numRep);
        }
    }
}