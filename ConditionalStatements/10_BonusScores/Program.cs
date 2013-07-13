using System;

class BonusScores
{
    static void Main()
    {
        /// Write a program that applies bonus scores to given scores in the range [1..9]. The program reads a digit as an input. 
        /// If the digit is between 1 and 3, the program multiplies it by 10; if it is between 4 and 6, multiplies it by 100; if it is between 7 and 9, multiplies it by 1000.
        /// If it is zero or if the value is not a digit, the program must report an error.
		/// Use a switch statement and at the end print the calculated new value in the console.
        Console.WriteLine("Program that applies bonus scores to given scores");

        int? bonus = null;

        // Input
        Console.Write("Enter digit: ");
        int a = int.Parse(Console.ReadLine());


        //Main Logic
        switch (a)
        {
        case 1: bonus = a * 10;
            break;
        case 2: bonus = a * 10;
            break;
        case 3: bonus = a * 10;
            break;
        case 4: bonus = a * 100;
            break;
        case 5: bonus = a * 100;
            break;
        case 6: bonus = a * 100;
            break;
        case 7: bonus = a * 1000;
            break;
        case 8: bonus = a * 1000;
            break;
        case 9: bonus = a * 1000;
            break;
        default: Console.WriteLine("Program applies bonus scores to given digit ONLY in the range [1..9]"); 
            break;
        }

        Console.WriteLine("Bonus applied to {0} is {1}", a, bonus);
    }
}