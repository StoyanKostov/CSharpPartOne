using System;


class MinMaxNember
{
    static void Main(string[] args)
    {
        /// Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.
        Console.WriteLine("Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.");

        int currentNummber;
        int maxNumber = int.MinValue;
        int minNumber = int.MaxValue;


        // Consol input
        Console.Write("Enter nummbers separated by space: ");
        string nummbers = Console.ReadLine();

        string[] arreyNumbers = nummbers.Split(' ');

        for (int i = 0; i < arreyNumbers.Length; i++)
        {
            currentNummber = int.Parse(arreyNumbers[i]);

            if (maxNumber < currentNummber)
            {
                maxNumber = currentNummber;
            }
            if (minNumber > currentNummber) 
            {
                minNumber = currentNummber;
            }

        }

        Console.WriteLine("Minimal number is: {0}\nMaximal number is: {1}", minNumber, maxNumber);
       
    }
}

