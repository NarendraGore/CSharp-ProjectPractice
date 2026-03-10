using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice.OOP.Overriding
{
    internal class GSTBill:Bill
    {
        override public double CalcBill(int amount) {
            return amount + amount * 0.18F;
        }
    }
}
