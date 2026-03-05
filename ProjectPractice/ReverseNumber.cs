using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice
{
    internal class ReverseNumber
    {
        int number, reverseNumber;

        internal void Accept() {
            Console.WriteLine("Enter the Three Digit Number:");
            number  =  Convert.ToInt32(Console.ReadLine());
        }
        internal void GetReverseNumber() {
            int a = number % 10;
            int b = (number / 10) % 10;
            int c = number / 100;
            reverseNumber = a *100+ b*10 + c;

            Console.WriteLine("Reverse Number is:{0}", reverseNumber);
        }
    }
}
