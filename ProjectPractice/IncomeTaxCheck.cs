using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice
{
    internal class IncomeTaxCheck
    {
        static void Main() {
            double salary;
            const double taxLimit = 250000;

            Console.WriteLine("Enter Yout salary: ");
            salary = Convert.ToDouble(Console.ReadLine());

            double taxableAmount = (salary > taxLimit) ? salary - taxLimit : 0;

            string message = (salary > taxLimit) ? "Your salary is taxable." : "Your salary is not taxable";

            Console.WriteLine(message);
            Console.WriteLine("Total salary: " + salary);
            Console.WriteLine("Taxable amount: " + taxableAmount); 

        }
                }
}
