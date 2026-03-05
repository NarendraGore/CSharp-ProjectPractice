using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice
{
    internal class PrimeCheckerFOr
    {
        static void Main()
        {
            int num;
            Console.WriteLine("Enter a Number:");
            num = Convert.ToInt32(Console.ReadLine());
            bool isPrime = true;
            for (int i = 2; i < num; i++)
            {

                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }

            }

            if (isPrime)
            {
                Console.WriteLine(num + " is  a Prime Number.");
            }
            else
            {
                Console.WriteLine(num + " is not a Prime Number.");
            }

        }
    }
}
