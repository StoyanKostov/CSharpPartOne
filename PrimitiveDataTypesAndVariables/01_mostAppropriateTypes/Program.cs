using System;

class IntegerTypes
{
    static void Main()
    {
        /// Declare five variables choosing for each of them the most appropriate of the types
        /// byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values:
        /// 52130, -115, 4825932, 97, -10000.
        ushort value52130 = 52130;
        sbyte valueNegative115 = -115;
        uint value4825932 = 4825932;
        sbyte value97 = 97;
        short valueNegative10000 = -10000;

        Console.WriteLine(
            "value52130 = {0}, valueNegative115 = {1},  value4825932 = {2}, value97 = {3}, valueNegative10000 = {4}",
            value52130, valueNegative115, value4825932, value97, valueNegative10000);
    }
}
