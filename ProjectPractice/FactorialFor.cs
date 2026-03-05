using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice
{
    internal class FactorialFor
    {
        //Factorial using For Loop
        static void Main()
        {
            int num ,factorial=1;
            Console.Write("Enter a Number: ");
            num  = Convert.ToInt32(Console.ReadLine());

            for (int i = num; i >= 1; i--) {
                factorial = factorial * i;

            
            }
            Console.WriteLine(factorial);
        }
        
    }
}
