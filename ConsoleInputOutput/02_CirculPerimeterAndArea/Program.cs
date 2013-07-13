using System;

class ReadsIntegersPrintsSum
{
    static void Main()
    {
        /// Write a program that reads the radius r of a circle and prints its perimeter and area.

        Console.WriteLine("Enter the radius of the circle");
        int r = int.Parse(Console.ReadLine());

        // Calculate perimeter
        double perimeter = 2 * Math.PI * r;

        // Calculate area
        double area = Math.PI * Math.Pow(r, 2);

        Console.WriteLine("The circle has perimeter = {0} and area = {1}", perimeter, area);
    }
}