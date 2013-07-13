using System;

class PointWithinCircle
{
    static void Main()
    {
        /// Write an expression that checks if given point (x,  y) is within a circle K(O, 5).
        sbyte pointX = 2;
        sbyte pointY = 2;

        // Expression
        bool check = (Math.Pow(pointX, 2) + Math.Pow(pointY, 2) <= Math.Pow(5, 2));

        Console.WriteLine("Point ({0},  {1}) is in the circle K(O, 5): {2}", pointX, pointY, check);
    }
}