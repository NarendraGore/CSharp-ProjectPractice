using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice
{
    internal class StarPatternFor
    {
        static void Main() {
            //Print star Pattern using nested
            for (int i = 1; i <= 5; i++) {
                for (int j = 1; j <= i; j++) {
                    Console.Write("*");
                
                }
                Console.WriteLine();
            }
            // Reverse Star Pattern

            for (int i = 5; i >= 1; i--) {
                for (int j = 1; j <= i; j++) {
                    Console.Write("*");

                }
                Console.WriteLine();

            }

        }
    }
}
