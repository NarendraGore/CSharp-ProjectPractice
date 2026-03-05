using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice
{
    internal class SalaryIncrease2
    {
        /*WAP to increase the Salary of an employee from 500 if the entered salary
         is less than 10000 otherwise increase by 800?*/

        static void Main() {

            double salary;
            Console.WriteLine("Enter Your Salary");
            salary = Convert.ToDouble(Console.ReadLine());

            if (salary < 10000) {

                Console.WriteLine("Your salary is Increased by 500.");
                salary = salary + 500;
                Console.WriteLine("Now, Your salary is:{0}",salary);
            }
            else { 
            Console.WriteLine("Your salary is Increased by 800.");
                salary = salary + 800;
                Console.WriteLine("Now, Your salary is:{0}",salary);
            }
                }
    }
}
