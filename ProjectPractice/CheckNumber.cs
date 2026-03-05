using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice
{
    internal class CheckNumber
    {
        static void Main()
        {
            //WAP to check number is positive or negative?
            int number;

            Console.WriteLine("Enter a number:");
            number = Convert.ToInt32(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("{0} is negative number.", number);

            }
            else {
                Console.WriteLine("{0} is positive number.", number);
            }

        }

    }
}
