using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice
{
    internal class ReverseWhile
    {
        //WAP to reverse any digit number?
        static void Main()
        {
            int num, reminder, rev = 0;
            Console.WriteLine("Enter a Number:");
            num = Convert.ToInt32(Console.ReadLine());
            while (num!=0) {
                reminder = num % 10;
                rev = rev*10+reminder;
                num = num / 10;
 
            }
            Console.WriteLine("Reverse Number is:" + rev);
        }
    }
}
