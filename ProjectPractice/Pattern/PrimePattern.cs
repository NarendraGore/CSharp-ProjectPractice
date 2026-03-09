using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice.Pattern
{
    internal class PrimePattern
    {
        static void Main() {
            int[] prime= new int[5];
            int num = 2;
            int count = 0;

            while (count<5) {
                int flag = 0;
                for (int i = 2; i < num; i++) {
                    if (num % i == 0) {
                        flag = 1;
                        break;
                    }
                
                }
                if (flag == 0)
                
                    {
                    prime[count] = num;
                    count++;
                    }
                num++;
            }


            for (int i = 0; i < prime.Length; i++) {
                for (int space = 0 ; space < i; space++) { 
                
                    Console.Write(" ");
                }
                for (int j = 0; j < prime.Length-i; j++) { 
                
                    Console.Write(prime[j]);
                }

                Console.WriteLine();
            }
           
        }
    }
}
