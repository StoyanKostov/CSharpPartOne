using System;

class FactDiv
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write a program that calculates N! * K! / (K - N)! for given N and K (1 < N < K).");

        uint factN = 1;
        uint factK = 1;

        // Consol input
        Console.Write("Enter N: ");
        uint n = uint.Parse(Console.ReadLine());

        Console.Write("Enter K: ");
        uint k = uint.Parse(Console.ReadLine());

        // Main Logic
        if (n > 1 && k > n)
        {
            while (k > n)
            {
                factK *= k;
                k--;
            }

            while (n > 1)
            {
                factN *= n;
                n--;
            }
            double result = factK * Math.Pow(factN, 2) / (k - n);

            // Consol Output
            Console.WriteLine("Result is: {0}", result);
        }
        else
        {
            Console.WriteLine("The condition for N and K is (1 < N < K)");
        }



    }
}

