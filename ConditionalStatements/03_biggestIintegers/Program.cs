using System;

class SignOfProduct
{
    static void Main()
    {
        /// Write a program that finds the biggest of three integers using nested if statements.
        Console.WriteLine("Write a program that finds the biggest of three integers using nested if statements.");

        string result = "";

        // Consol input
        Console.Write("Enter first integer a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter second integer b: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Enter second integer c: ");
        int c = int.Parse(Console.ReadLine());

        //Main Logic

        if (a > b)
        {
            if (c > a)
            {
                result = "c";
            }
            else
            {
                result = "a";
            }
 
        }
        else
        {
            if (c > b)
            {
                result = "c";
            }
            else
            {
                result = "b";
            }
        }

        // Consol output
        Console.WriteLine("The biggest integer is of a: {0}, b: {1} and c: {2} is {3}", a, b, c, result);
    }
}