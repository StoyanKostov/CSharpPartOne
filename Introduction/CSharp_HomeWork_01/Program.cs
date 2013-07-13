using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_HomeWork_01
{
    class HomeWorkProgram
    {
        static void Main()
        {
            /// 2. Create, compile and run a “Hello C#” console application.
            Console.WriteLine("Hello C#");

            /// 3. Modify the application to print your name.
            Console.WriteLine("Stoyan");

            /// 4. Write a program to print the numbers 1, 101 and 1001.
            Console.WriteLine("{0}, {1}, {2}", 1, 101, 1001);

            /// 7. Create console application that prints your first and last name.
            Console.WriteLine("{0} {1}", "Stoyan", "Kostov");

            /// 8. Create a console application that prints the current date and time.
            Console.WriteLine("Current date and time: {0}", DateTime.Now);

            /// 9. Create a console application that calculates and prints the square of the number 12345.
            int Value = 12345;
            Console.WriteLine(Math.Pow(Value, 2));

            /// 10. Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
            int SequenceMembers = 12;
            for (int i = 2; i < SequenceMembers; i++) // Separates even from odd numbers and if odd change value to negative
            {
                if (i % 2 == 0) 
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(-i);
                }
            }
        }
    }
}
