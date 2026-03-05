using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice
{
    internal class AreaOfTriangle
    {
        double area, baseValue, height;

        internal void Accept() {
            Console.WriteLine("Enter the Base Value OF Triangle:");
            baseValue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ENter the Height of the Trianlge:");
            height = Convert.ToDouble(Console.ReadLine());

        }
        internal void areaTriangle() { 
        area = 0.5*baseValue*height;
            Console.WriteLine("Area of the Triangle is:{0}", area);
        }
    }
}
