using System;

class TrapezoidArea
{
    static void Main()
    {
        /// Write an expression that calculates trapezoid's area by given sides a and b and height h.
        float a = 2f;
        float b = 5f;
        float h = 9f;

        // Expression
        float trapezoidArea = h * (a + b) / 2;

        Console.WriteLine("The trapezoid's area is equal to {0}", trapezoidArea);
    }
}