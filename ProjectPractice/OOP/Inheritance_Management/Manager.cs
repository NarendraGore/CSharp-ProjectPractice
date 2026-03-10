using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice.OOP.Inheritance_Management
{
    internal class Manager:Admin
    {
        internal double salary;
        internal void GetManagerData()
        {
            GetAdminData();
            Console.Write("Enter salary :");
            salary = Convert.ToDouble(Console.ReadLine());

        }
        internal void ShowManagerData()
        {
            ShowAdminData();
            Console.WriteLine("Salary: " + salary);
        }

    }
}
