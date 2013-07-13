using System;

class IsPrime
{
    static void Main()
    {
        /// Write an expression that checks if given positive integer number n (n <= 100) is prime. E.g. 37 is prime.
        byte number = 8;
        bool prime = true;

        // Expression
        if (0 > number || number > 100)
        {
            Console.WriteLine("Integer is NOT between 0 and 100");
        }
        else
        {
            if (number == 1 || number == 0)
            {
                Console.WriteLine("Integer is neither true or false");
            }
            else
            {
                for (int i = 2; i < number; i++)
                {
                    // Number is NOT prime if can be devided without remainder
                    if (number % i == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                Console.WriteLine("The given positive integer {0} is prime: {1}", number, prime);
            }
        }
    }
}