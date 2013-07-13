using System;
//using Math;

class QuadraticEquationCoefficients
{
    static void Main()
    {
        /// Write a program that enters the coefficients a, b and c of a quadratic equation a*x2 + b*x + c = 0
        /// and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.
        Console.WriteLine("Enter the coefficients a, b and c of a quadratic equation a*x2 + b*x + c = 0");

        // Consol input
        Console.Write("Enter coefficient a: ");
        float a = float.Parse(Console.ReadLine());

        Console.Write("Enter coefficient b: ");
        float b = float.Parse(Console.ReadLine());

        Console.Write("Enter coefficient c: ");
        float c = float.Parse(Console.ReadLine());

        //Main Logic
        double D = Math.Pow(b, 2) - 4 * a * c;
        Console.WriteLine("Determinant is {0}", D);

        if (D < 0)
        {
            Console.WriteLine("There are no real roots");
        }
        else if (D == 0)
        {
            double x1 = -b / (2 * a);
            Console.WriteLine("One real root = {0}", x1);
        }
        else 
        {
            double x1 = (-b / 2 + Math.Sqrt(D)) / a;
            double x2 = (-b / 2 - Math.Sqrt(D)) / a;
            Console.WriteLine("Root x1 = {0}, Root x2 = {1}", x1, x2);
        }
    }
}