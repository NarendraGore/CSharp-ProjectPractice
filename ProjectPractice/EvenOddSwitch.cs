using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice
{
    internal class EvenOddSwitch
    {
        //WAP to check even|odd using switch?
        static void Main() {
            int num;
            Console.WriteLine("Enter a number: ");

            num = Convert.ToInt32(Console.ReadLine());
            switch (num % 2) { 
                case 0:
                    Console.WriteLine(num + " is Even number.");
                    break;

                case 1:
                    Console.WriteLine(num+" is Odd number.");
                    break;
            }
        }
    }
}
