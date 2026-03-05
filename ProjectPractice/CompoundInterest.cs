using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice
{
    internal class CompoundInterest
    {
        double A, P, R, T;
        internal void Accept() {

            Console.WriteLine("Enter The Principal Amount:");
            P = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Rate Of Interest:");
            R= Convert.ToDouble(Console.ReadLine()) ;
            Console.WriteLine("Enter the Years:");
            T = Convert.ToDouble(Console.ReadLine());

          

        }
        internal void FinalAmount() {

            A = P * Math.Pow(1 + R / 100, T);
            Console.WriteLine("Final Amount = {0}",A);
                }
        
    }
}
