using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice
{
    internal class SumDateDigit
    {
        static void Main() {
            String date = "12052016";
            int d1 = Convert.ToInt32(date);

            int sum = 0;

            while (d1 > 0) {
                int first = d1 % 10;
                d1 = d1 / 10;
                sum = sum + first;
                
            }
            Console.WriteLine("Sum of Date of Birth is:{0}",sum);

           /* int first = d1 % 10; //6
            d1 = (int)(d1 / 10);//1205201
            int second = d1 % 10;//1
            d1 = (int)(d1 / 10);//120520
            int third = d1 % 10;//0
            d1 = (int)(d1 / 10);//12052
            int fourth = d1 % 10;//2
            d1 = (int)(d1 / 10);//1205
            int fifth = d1 % 10;//5
            d1 = (int)(d1 / 10);//120
            int sixth = d1 % 10;//0
            d1 = (int)(d1 / 10);//12
            int seventh = d1 % 10;//2
            d1 = (int)(d1 / 10);//1
            int eigth = d1 % 10;//1
            Console.WriteLine("Sum of Date of Birth is:{0}",first+second+third+fourth+fifth+sixth+seventh+eigth);*/
            

        }
    }
}
