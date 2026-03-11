using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice.OOP.Exception_Handling
{
    internal class ExceptionClass
    {
        static void Main() {
            int num;
            try {
                Console.WriteLine("Enter a number");
                num = Convert.ToInt32(Console.ReadLine());
                if (num < 0) {
                    throw new NegativeNumberException();
                }
                Console.WriteLine("Number is "+num);
            }
            catch (NegativeNumberException e) {
            Console.WriteLine(e.Message.ToString());
            }
        
        }
    }
}
