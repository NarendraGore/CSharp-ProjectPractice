using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice.Array
{
    internal class MaxArr
    {
        static void Main() { 
            int[] arr = { 1, 23, 56, 654, 655,989798 ,8973, 61, 65, 4 };

            int max = int.MinValue;
            int secondMax= int.MaxValue;

            foreach (int num in arr) {

                if (num > max)
                {
                    secondMax = max;
                    max = num;
                }
                else if (num > secondMax && num != max) {
                    secondMax = num;
                }
            }
            Console.WriteLine("max:{0} && secondmax:{1}", max, secondMax);
        }
    }
}
