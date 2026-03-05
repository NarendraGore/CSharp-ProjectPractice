using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice
{
    internal class FibonaccieWhile
    {
        //WAP to display fibonacci series?
        static void Main() {
            int a = 0, b = 1, c,i=1, n;
            Console.Write("Enter Number of Terms:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write(a+"  "+b+"  ");

            while (i<= n - 2) {
                c = a + b;
                Console.Write(c+ " ");
                a = b;
                b=c;
                i++;
            
            }
        
        }
    }
}
