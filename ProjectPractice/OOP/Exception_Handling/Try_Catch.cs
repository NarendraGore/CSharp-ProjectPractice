using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice.OOP.Exception_Handling
{
    internal class Try_Catch
    {
        static void Main()
        {
            string s="";
            try
            {
                int a, b, c;
                Console.WriteLine("Enter a Number:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Second Number");
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine(c);
                s = "success";

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Enter only Numeric Value.");
                s = "fail";

            }
            catch (DivideByZeroException ex1)
            {
                Console.WriteLine("Denominator Can not be zero.");
                s = "fail";

            }
            finally {
               Console.WriteLine(s); 
            }
        
        }
    }
}
