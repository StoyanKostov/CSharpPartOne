using System;

class SortValuesDescendingOrder
{
    static void Main()
    {
        /// Sort 3 real values in descending order using nested if statements.
        Console.WriteLine("Sort 3 real values in descending order using nested if statements.");

        string result = "";

        // Consol input
        Console.Write("Enter first integer a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter second integer b: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Enter second integer c: ");
        int c = int.Parse(Console.ReadLine());

        //Main Logic

        if (a > b)
        {
            if (b > c)
            {
                result = "a > b > c";
            }
            else
            {
                if (a > c)
                {
                    result = "a > c > b";
                }
                else
                {
                    result = "c > a > b";
                }
            }
        }
        else
        {
            if (a > c)
            {
                result = "b > a > c";
            }
            else
            {
                if (b > c)
                {
                    result = "b > c > a";
                }
                else
                {
                    result = "c > b > a";
                }
            }
        }

        // Consol output
        Console.WriteLine("a: {0}, b: {1}, c: {2} in in descending order {3}", a, b, c, result);
    }
}