using System;

class FloatOrDouble
{
    static void Main()
    {
        /// Which of the following values can be assigned to 
        /// a variable of type float and which to a variable of type double:
        /// 34.567839023, 12.345, 8923.1234857, 3456.091
        float value12p345 = 12.345f, value3456p091 = 3456.091f;
        double value34p567839023 = 34.567839023, value8923p1234857 = 8923.1234857;

        Console.WriteLine(
            "Floats: {0}, {1} \nDoubles: {2}, {3}",
            value12p345, value3456p091, value34p567839023, value8923p1234857);
    }
}