using System;

class ThirdDigit7
{
    static void Main()
    {
        /// Write an expression that checks for given integer
        /// its third digit (right-to-left) is 7. E. g. 1732 is true.
        int value = 231700;

        // Expression
        bool result = ((value / 100) % 10 == 7);

        Console.WriteLine("Third digit of {0} is 7: {1}", value, result);
    }
}