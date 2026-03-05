using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice
{
    internal class DateDiff
    {
        static void Main() {

            String date1 = "12052016";
            String date2 = "13062019";
            int d1 = Convert.ToInt32(date1);
            int d2 = Convert.ToInt32(date2);
            int y1 = d1 % 10;
            int y2 = d2 % 10;
            Console.WriteLine("Difference of Date in Year {0}",y2-y1);
        
        }
    }
}
