using System;

class OddOrEven
{
    static void Main()
    {
        /// Write an expression that checks if given integer is odd or even.
        int value = 6;

        //Expression
        bool result = (value % 2 == 0);

        Console.WriteLine("{0} is even = {1}", value, result);
    }
}