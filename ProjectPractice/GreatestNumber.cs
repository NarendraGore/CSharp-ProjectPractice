using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice
{
    internal class GreatestNumber
    {
        //WAP to check greatest using four different numbers?
        static void Main()
        {

            int num1, num2, num3, num4;
            Console.WriteLine("Enter 4 numbers:");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());
            num4 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3 && num1 > num4)
            {
                Console.WriteLine("{0} is a greater number",num1);

            }
            else if (num2 > num3 && num2 > num4)
            {
                Console.WriteLine("{0} is greater number",num2);
            }
            else if (num3 > num4)
            {
                Console.WriteLine("{0}is greater number",num3);

            }
            else { 
                Console.WriteLine("{0} is greater number",num4);
            }
        }
    }
}
