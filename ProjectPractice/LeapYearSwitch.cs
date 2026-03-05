using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice
{
    internal class LeapYearSwitch
    {
        //WAP to check leap year using a switch?

        static void Main() {
            int year;
            Console.WriteLine("Enter Year to Check Leap or Not");
            year = Convert.ToInt32(Console.ReadLine());

            switch (year % 4) { 
                
                case 0:
                    Console.WriteLine(year + " Is Leap Year");
                    break;
                case 1:
                    Console.WriteLine(year+" is not Leap Year");
                    break;
            }

        }
    }
}
