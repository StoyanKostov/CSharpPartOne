using System;

class InCircleAndOutRectangle
{
    static void Main()
    {
        /// Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3)
        /// and out of the rectangle R(top=1, left=-1, width=6, height=2).
        int pointX = 0;
        int pointY = 2;

        // Expression
        bool check = ((Math.Pow(pointX - 1, 2) + Math.Pow(pointY - 1, 2) <= Math.Pow(3, 2)) && !((pointX > -1) && (pointY < 1) && (pointY > -1)));

        Console.WriteLine("The given point ({0}, {1}) is within the circle and out of the rectangle: {2}", pointX, pointY, check);
    }
}