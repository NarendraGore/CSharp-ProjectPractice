using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice.OOP
{
    internal class StudentMarks
    {
        private int stdRNo;
        private string stdName;
        internal int stdMarks;

        internal void Accept(int stdRNo, string stdName, int stdMarks) {
            this.stdRNo = stdRNo;
            this.stdName = stdName;
            this.stdMarks = stdMarks;

        }
        internal void Display() {
            Console.WriteLine("Student Roll No is :{0}",stdRNo);
            Console.WriteLine("Student Name is:{0}",stdName);
            Console.WriteLine("Student Marks are:{0}",stdMarks);
        }
    }
}
