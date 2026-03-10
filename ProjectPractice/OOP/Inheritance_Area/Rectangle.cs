using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice.OOP.Inheritance_Area
{
    internal class Rectangle:Circle
    {
      internal int param2;

        internal void Accept2(int param2) {

            this.param2 = param2;

        }
        internal void RectangleArea() {
            area = param1 * param2;
        }

        
    }
}
