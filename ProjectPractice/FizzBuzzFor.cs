using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice
{
    internal class FizzBuzzFor
    {
        static void Main() {
            /*The FizzBuzz Classic: * Print numbers 1 to 50.
             * If divisible by 3, print "Fizz".
             * If divisible by 5, print "Buzz".
             * If divisible by both, print "FizzBuzz".*/

            Console.WriteLine("Printing Numbers From 1 to 10:");

            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine(i);
                if (i % 3 == 0)
                {

                    if (i % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else {
                        Console.WriteLine("Fizz");
                    }
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
               
            }
        }
    }
}
