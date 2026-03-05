using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice
{
    internal class SimpleInterest
    {

        /*WAP to calculate Simple Interest where rate and time will be
         * constant and the principal will be an integer?*/

        static void Main() {

            int principalAmt;
           const double rate = 2;
            const double time = 3.5;
            double simpleInterest, totalAmount;
            Console.WriteLine("Enter the Principal Amount Of Loan : ");
            principalAmt = Convert.ToInt32(Console.ReadLine());

            simpleInterest = (principalAmt*rate*time) / 100;
            totalAmount = simpleInterest + principalAmt;


            Console.WriteLine("Simple Interest is: {0}",simpleInterest);
            Console.WriteLine("Total Amount With Interest is :{0}",totalAmount);

        }
    }
}
