using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice
{
    internal class FibonacciFor
    {
        static void Main() {
            int a = 0, b = 1, c, n;
            Console.WriteLine("Enter number of Terms:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a);
            Console.WriteLine(b);
            for (int i = 1; i < n - 2; i++) {

              
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;


            }

        }
    }
}
