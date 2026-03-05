using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice
{
    internal class AreaOfCircle
    {
        double area, radius;
        internal void Accept() {
            Console.WriteLine("Enter The Radius of a circle:");
            radius = Convert.ToDouble(Console.ReadLine());

        }
        internal void AreaCircle() { 
        area = Math.PI* radius*radius;
            Console.WriteLine("Area of a Circle is:{0}", area);
                }
    }
}
