using System;

class QuotationsDifficulties
{
    static void Main()
    {
        /// Declare two string variables and assign them with following value:
        /// The "use" of quotations causes difficulties.
        /// Do the above in two different ways: with and without using quoted strings.
        string firstString = "The \"use\" of quotations causes difficulties", secondString = @"The ""use"" of quotations causes difficulties.";

        Console.WriteLine(firstString);
        Console.WriteLine(secondString);

    }
}