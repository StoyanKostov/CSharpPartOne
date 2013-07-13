using System;

class ExchangesValues
{
    static void Main()
    {
        /// Write an if statement that examines two integer variables and exchanges their values 
        /// if the first one is greater than the second one.
        Console.WriteLine("Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.");

        // Consol input
        Console.Write("Enter first integer a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter second integer b: ");
        int b = int.Parse(Console.ReadLine());

        //Main Logic
        string result = "";
        
        if (a < b)
        { 
            a = a + b;
            b = a - b;
            a = a - b;
            result = "a is smaller than b, values has been exchanged";
        }
        else if (a > b)
        {
            result = "a is greater than b";
        }
        else
        {
            result = "a and b are equal";
        }

        // Consol output
        Console.WriteLine("{0},\nvalue of a is {1}, value of b is {2}", result, a, b);
    }
}