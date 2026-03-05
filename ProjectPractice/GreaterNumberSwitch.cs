using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice
{
    internal class GreaterNumberSwitch
    {
        static void Main() {
            //WAP to check the greater number using Switch?

            int num1, num2;
            Console.Write("Enter First Number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number:");
            num2= Convert.ToInt32(Console.ReadLine());

            switch (num1 > num2) { 
            
                case true:
                    Console.WriteLine(num1 + " is greater than " + num2);
                    break;

                case false:
                    Console.WriteLine(num2 + " is greater than " + num1);
                    break;
            }

        }
    }
}
