using System;
using System.Collections.Generic;

class Matrix
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix.");

        string row = "";

        // Consol input
        Console.Write("Enter positive integer: ");
        int n = int.Parse(Console.ReadLine());
       
        // Main logic
        n = n + 1;
        int k = n;


        for (int i = 1; i < n; i++)
        {
            int j = i;

            while (j < k)  // Rows
            {
                if (j < 10)
                {
                    row += " " + j + " ";
                    j += 1;
                }
                else
                {
                    row += j + " ";
                    j += 1;
                }
            }

            k += 1;
            row += "\n\n"; // New row
        }

        // Consol output
        Console.WriteLine(row);
    }
}