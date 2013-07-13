using System;

class NullValues
{
    static void Main()
    {
        /// Create a program that assigns null values to an integer and to double variables. 
        /// Try to print them on the console, try to add some values or the null literal to them and see the result.
        int? someInteger = null;
        double? someDouble = null;
        Console.WriteLine("This is the integer = {0} and double = {1} with Null values", someInteger, someDouble);
        someInteger = 5;
        someDouble = 2.5;
        Console.WriteLine("This is the integer = {0} and double = {1} with some values", someInteger, someDouble);
    }
}