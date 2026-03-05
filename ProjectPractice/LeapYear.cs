using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice
{
    internal class LeapYear
    {
        static void Main() {
            int year = 800;
            String output = year % 400 == 0 || (year % 4 == 0 && year % 100 != 0) ?"Year Is Leap Year.":"Year Is Not Leap Year.";
            Console.WriteLine("{0} This {1}",year, output);
        
        }
    }
}
