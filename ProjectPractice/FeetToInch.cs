using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice
{
    internal class FeetToInch
    {
        double feet, inch;

        internal void Accept() {
            Console.WriteLine("Enter Length in Feet:");
            feet = Convert.ToDouble(Console.ReadLine());
        }

        internal void GetInch() {
            inch = feet * 12;
            Console.WriteLine("Feet to Inch:{0}", inch);
        }
    }
}
