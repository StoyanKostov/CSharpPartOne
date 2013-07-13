using System;
//using Math;

class GreatestOf5Variables
{
    static void Main()
    {
        /// Write a program that finds the greatest of given 5 variables.
        Console.WriteLine("Enter 5 variables a, b, c, d, e");

        
        // Input
        Console.Write("Enter variable a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter variable b: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Enter variable c: ");
        int c = int.Parse(Console.ReadLine());

        Console.Write("Enter variable d: ");
        int d = int.Parse(Console.ReadLine());

        Console.Write("Enter variable e: ");
        int e = int.Parse(Console.ReadLine());

        //Main Logic
        int result;

        if ((a > b) && (a > c) && (a > d) && (a > e))
        {
            result = a;
        }
        else if ((b > c) && (b > d) && (b > e))
        {
            result = b;
        }
        else if ((c > d) && (c > e))
        {
            result = c;
        }
        else if (d > e)
        {
            result = d;
        }
        else
        {
            result = e;
        }

        // Output
        Console.WriteLine("the greatest of given a: {0}, b: {1}, c: {2}, d: {3}, e: {4} is {5}", a, b, c, d, e, result);
    }
}