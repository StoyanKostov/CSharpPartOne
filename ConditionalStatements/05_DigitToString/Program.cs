using System;

class DigitToString
{
    static void Main()
    {
        /// Write program that asks for a digit and depending on the input shows the name of that digit (in English) using a switch statement.
        Console.WriteLine("Write program that asks for a digit and depending on the input shows the name of that digit (in English) using a switch statement.");

        string result = "";

        // Consol input
        Console.Write("Enter digit: ");
        int a = int.Parse(Console.ReadLine());

        //Main Logic

        switch (a)
        {
            case 0: result = "Zero";
                break;
            case 1: result = "One";
                break;
            case 2: result = "Two";
                break;
            case 3: result = "Three";
                break;
            case 4: result = "Four";
                break;
            case 5: result = "Five";
                break;
            case 6: result = "Six";
                break;
            case 7: result = "Seven";
                break;
            case 8: result = "Eight";
                break;
            case 9: result = "Nine";
                break;
            default: result = "out of digit range!";
                break;
        } 

        // Consol output
        Console.WriteLine("Your digit is {0}, \nIts name is {1}", a, result);
    }
}