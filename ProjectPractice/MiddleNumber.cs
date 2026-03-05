using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice
{
    internal class MiddleNumber
    {

        static void Main() {
            int number, middleNumber;

            Console.Write("Enter a Three Digit NUmber: ");
            number = Convert.ToInt32(Console.ReadLine());

            middleNumber = (number / 10) % 10;
            Console.Write("Middle Number of Three Digit Number is: {0}",middleNumber);
        }
    }
}
