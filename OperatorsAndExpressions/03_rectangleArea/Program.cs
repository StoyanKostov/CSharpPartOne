using System;

class RectangleArea
{
    static void Main()
    {
        /// Write an expression that calculates rectangle’s area by given width and height.
        uint rectangleWidth = 15;
        uint rectangleHeight = 35;

        // Expression for calculation of rectangle’s area
        ulong rectangleArea = rectangleWidth * rectangleHeight;

        Console.WriteLine("Rectangle\'s area = {0}", rectangleArea);
    }
}