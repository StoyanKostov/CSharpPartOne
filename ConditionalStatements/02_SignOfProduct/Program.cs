using System;

class SignOfProduct
{
    static void Main()
    {
        /// Write a program that shows the sign (+ or -) of the product of three real numbers 
        /// without calculating it. Use a sequence of if statements.
        Console.WriteLine("Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.");

        // Consol input
        Console.Write("Enter first integer a: ");
        float a = float.Parse(Console.ReadLine());

        Console.Write("Enter second integer b: ");
        float b = float.Parse(Console.ReadLine());

        Console.Write("Enter second integer c: ");
        float c = float.Parse(Console.ReadLine());

        //Main Logic
        
        string result = "";

        // If values positive assign True
        bool aSign =  a > 0 ? true : false;
        bool bSign = b > 0 ? true : false;
        bool cSign = c > 0 ? true : false;

        if (aSign ^ bSign ^ cSign) // Most suitable operator is Xor
        {
            result = "Product is positve";
        }
        else if (a == 0 || b == 0 || c == 0)
        {
            result = "Product is zero";
        }
        else
        {
            result = "Product is negative";
        }

        // Consol output
        Console.WriteLine("{0}", result);
    }
}