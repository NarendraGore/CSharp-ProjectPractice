using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice
{
    internal class TableWhile
    {
        //WAP to display the table of numbers?
        static void Main() {
            int num;
            int i = 1;
            Console.WriteLine("Enter a Number:");
            num = Convert.ToInt32(Console.ReadLine());

            while (i <= 10) { 
                
                Console.WriteLine(num+ " X "+ i+" : "+(num*i));
                i++;
            }

                }
    }
}
