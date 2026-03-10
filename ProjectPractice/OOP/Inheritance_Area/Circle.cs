using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice.OOP.Inheritance_Area
{
    internal class Circle
    {
        internal int param1;
        internal float area;
         internal void Accept1(int param1) { 
        this.param1 = param1;
        }
        internal void CircleArea() {
            area = 3.14f * param1*param1;
        }
        internal void Display() {
            Console.WriteLine("Area is {0}",area);
        }
    }
}
