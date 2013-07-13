using System;

class CompareFloatingPoints
{
    static void Main()
    {
        /// Write a program that safely compares floating-point 
        /// numbers with precision of 0.000001. Examples:
        /// (5.3 ; 6.01) = false;  (5.00000001 ; 5.00000003) = true
        decimal firstValue = 5.00000001M;
        decimal secondValue = 5.00000003M;

        // Round number to 6th digit after the floating point
        firstValue = Math.Round(firstValue, 6);
        secondValue = Math.Round(secondValue, 6);

        bool compareFloatingPoints = (firstValue == secondValue);

        Console.WriteLine(
            "First and second values are equal: {0}",
            compareFloatingPoints);
    }
}