using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice
{
    internal class SalaryIncrease
    {
        static void Main() {
            /*WAP to increase the salary of employees from 500 if entered salary
            will be less than 10000 otherwise the same salaries will be displayed.*/

            double salary;

            Console.WriteLine("Enter your salary");
            salary = Convert.ToDouble(Console.ReadLine());

            if (salary < 10000)
            {
                salary = salary + 500;
                Console.WriteLine("Salary increased by 500 and your salary is {0}",salary);
            }
            else {
                Console.WriteLine("Salary is not increased and your salary is {0}", salary);

            }

        }
    }
}
