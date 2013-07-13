using System;

class ExchangeIntergerValues
{
    static void Main()
    {
        /// Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.
        byte firstInt = 5;
        byte secondInt = 10;
        byte temp = firstInt;
        firstInt = secondInt;
        secondInt = temp;

        Console.WriteLine(
            "Exchanged values:\nfirstInt = {0},\nsecondInt = {1}",
            firstInt, secondInt);
    }
}