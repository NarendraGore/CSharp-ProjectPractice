using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice
{
    internal class NumberPattern1For
    {
        static void Main() {

            /*
             10101
             1010
             101
             10 
             1
             */

            for (int i = 1; i <= 5; i++) {
               
                for (int j = 1; j <=6 - i; j++) {
                    if (j % 2 != 0)
                    {
                        Console.Write("1");
                    }
                    else { 
                        Console.Write("0");

                    }
                }
                for (int space = 1; space < i; space++)
                {
                    Console.Write(" ");
                }   
                Console.WriteLine();
            
            }

           

        }
    }
}
