using System;

class SolveQuadraticEquation
{
    static void Main()
    {
        /// Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).

        // Consol input
        Console.WriteLine("Enter the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0");
        
        Console.WriteLine("Enter coefficients a");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter coefficients b");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter coefficients c");
        int c = int.Parse(Console.ReadLine());

        // Main Logic
        double d = Math.Pow(b,2) - 4*a*c;
        if (d < 0)
	    {
            Console.WriteLine("There are no real roots");
	    }
        else if (d == 0)
        {
            double result = -b / (2 * a);
            Console.WriteLine("There is one real root = {0}", result);
        }
        else {
            double x1 = (-b/2 + Math.Sqrt(d)) / a;
            double x2 = (-b/2 - Math.Sqrt(d)) / a;
            Console.WriteLine("There are two real roots = {0} and {1}", x1, x2);
        }
    }
}