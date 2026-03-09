using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice.Array
{
    internal class SumOfArr
    {
        static void Main()
        {
            /*1. Sum & Average** * **Task:** Create an array of 5 integers. Use a loop to find the sum of all 
              elements and then calculate the average.
              Goal:** Learn how to accumulate values while traversing an array.*/

            int[] num = [5, 10, 20, 30, 40];
            int sum = 0;
            for (int i = 0; i <num.Length ; i++) { 
                sum = sum + num[i];
               
            }
            Console.WriteLine("Sum of Array element is:"+sum);
        }
    }
}
