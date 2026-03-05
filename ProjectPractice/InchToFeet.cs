using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice
{
    internal class InchToFeet
    {
        double feet, inch;

        internal void Accept()
        {
            Console.WriteLine("Enter the Length in Inch:");
            inch = Convert.ToDouble(Console.ReadLine());
        }
        internal void GetFeet()
        {
            feet = inch / 12;
            Console.WriteLine("Length in Feet:{0}", feet);
        }
    }
}
