using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice.OOP.Abstraction
{
    internal class AbstractChildArea:AbstractArea
    {
        internal override void triangle()
        {
            area = (param1 * param2) / 2;
        }
        internal override void rectangle()
        {
            area = param1 * param2;
        }
    }
}
