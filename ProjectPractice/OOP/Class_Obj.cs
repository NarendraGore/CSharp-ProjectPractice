using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice.OOP
{
    internal class Class_Obj
    {
        private int empid;
        private string empName;
        private int empSalary;

        internal void Accept(int empid, string empName,int empSalary) {
        

            this.empid = empid;
            this.empName = empName;
            this.empSalary = empSalary;
        }
        internal void Display() {

            Console.WriteLine("Employee Id:{0}",empid);
            Console.WriteLine("Employee Name:{0}", empName);
            Console.WriteLine("Employee Salary:{0}",empSalary);
        }
    }
}
