using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice
{
    internal class FactorialWhile
    {
        //WAP to calculate Factorial?
        static void Main()
        {
            int num, factorial=1;
            Console.WriteLine("Enter a Number to FInd Factorial");
            num = Convert.ToInt32(Console.ReadLine());

            int i = 1;
            while (i <= num) { 
                factorial = factorial * i;
               
                i++;
            }
            Console.WriteLine("Factorial of " + num + ":" + factorial);
        }
        
    }
}
