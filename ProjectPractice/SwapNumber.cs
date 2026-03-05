using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice
{
    internal class SwapNumber
    {
        static int a = 5, b = 10;
        internal static void swap() {

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine("value of a = {0}, b = {1}", a, b);
        }


    }
}
