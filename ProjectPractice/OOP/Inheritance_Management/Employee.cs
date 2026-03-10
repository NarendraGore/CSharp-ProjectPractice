using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice.OOP.Inheritance_Management
{
    internal class Employee : Manager
    {
        internal double incentive;
        internal void GetEmployeeData (){
            GetManagerData();
            Console.Write("Enter Incentive: ");
            incentive = Convert.ToDouble(Console.ReadLine());

}
        internal void ShowEmployeeData() { 
            
            ShowManagerData();
            Console.WriteLine("Incentive: "+incentive);
        }
    }
}
