using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice
{
    internal class DivisibilityCheck
    {
        static void Main() {

            int number ;
            Console.WriteLine("Enter a Number: ");
            number = Convert.ToInt32(Console.ReadLine());

            String divisiibility = (number % 3 == 0 && number % 5 == 0) ? "Number is Divisible By 3 & 5" : "Number is not divisible by 3 & 5";
            Console.WriteLine(divisiibility);
        }
    }
}
