using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice.OOP.Exception_Handling
{
    internal class Throw_Keyword
    {
        static void Main() {
            int num;
            try
            {
                Console.WriteLine("Enter a number");
                num = Convert.ToInt32(Console.ReadLine());
                if (num < 0) {
                    throw new Exception();
                }
                Console.WriteLine("Number is Num"+num);
            }
            catch(Exception ex) {
                Console.WriteLine("Enter +ve number");
            }
            }
        }
    }
    
