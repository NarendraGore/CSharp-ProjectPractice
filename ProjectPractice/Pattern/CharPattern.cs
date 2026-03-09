using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice.Pattern
{
    internal class CharPattern
    {
        static void Main() {
            /*
             MANISH
              ANISH
               NISH
                ISH
                 SH
                  H*/

            string str = "MANISH";

            for (int i = 0; i < str.Length; i++) {

                for (int space = 0; space < i; space++) {
                    Console.Write(" ");
                }	

                for (int j = i; j < str.Length; j++) {
                    Console.Write(str[j]);
                }
                Console.WriteLine();
            
            }
        
        }
    }
}
