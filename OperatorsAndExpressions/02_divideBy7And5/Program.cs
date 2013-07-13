using System;

class DivideBy7And5
{
    static void Main()
    {
        /// Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.
        int value = 35;

        // Expression
        bool result = (value % 5 == 0 && value % 7 == 0);

        Console.WriteLine("{0} can be divided (without remainder) by 7 and 5 in the same time = {1}", value, result);
    }
}