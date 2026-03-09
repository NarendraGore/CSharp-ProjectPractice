using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice.Pattern
{
    internal class NumberPatternn
    {
        static void Main() {
            int n = 5;
            for (int i = 1; i <= 5; i++) {
                for (int space = 1; space < i; space++) {
                    Console.Write(" ");
                
                }
                for (int j = i; j <= 5; j++) {


                    Console.Write((j % 2 == 0) ? "2" : "1");

                }
                Console.WriteLine();    
            
            }
        
        }
    }
}
