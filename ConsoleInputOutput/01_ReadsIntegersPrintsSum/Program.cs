using System;

class ReadsIntegersPrintsSum
{
    static void Main()
    {
        /// Write a program that reads 3 integer numbers from the console and prints their sum.

        Console.WriteLine("Enter first integer for adding");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second integer for adding");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter third integer for adding");
        int c = int.Parse(Console.ReadLine());

        //Make calculation
        int result = a + b + c;

        Console.WriteLine("Sum of tree integers is = {0}", result);
    }
}