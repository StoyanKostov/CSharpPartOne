using System;

class UserChoiceInput
{
    static void Main()
    {
        /// Write a program that, depending on the user's choice inputs int, double or string variable.
        /// If the variable is integer or double, increases it with 1. 
        /// If the variable is string, appends "*" at its end. The program must show the value of that variable as a console output. Use switch statement.
        Console.WriteLine("If the variable is integer or double, increases it with 1.\nIf the variable is string, appends \" * \" at its end.");


        // Input
        Console.Write("Enter variable : ");
        string input = Console.ReadLine();
        int a;
        double b;

        //Main Logic

        if (int.TryParse(input, out a))
        {
            a += 1;
            Console.WriteLine("Variable is int and {0} + 1 = {1}", input, a);
        }
        else if (double.TryParse(input, out b))
        {
            b += 1;
            Console.WriteLine("Variable is double and {0} + 1 = {1}", input, b);
        }
        else 
        {
            input += "*";
            Console.WriteLine("Variable is string and plus \"*\" is = {0}", input);
        }
    }
}