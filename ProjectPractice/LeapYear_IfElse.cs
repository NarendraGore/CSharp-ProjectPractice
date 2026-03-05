using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice
{
    internal class LeapYear_IfElse
    {
        //WAP to Check Leap Year? 
        static void Main() {

            int year;
            Console.Write("Enter year to check Leap Year: ");
            year = Convert.ToInt32(Console.ReadLine());

            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            {

                Console.Write("{0} year is Leap Year.", year);
            }
            else {
                Console.Write("{0} year is Not Leap Year.", year);

            }
        }
    }
}
