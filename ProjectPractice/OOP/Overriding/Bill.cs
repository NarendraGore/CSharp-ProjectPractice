using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice.OOP.Overriding
{
    internal class Bill
    {
        virtual public double CalcBill(int amount) {
            return amount;
        }
    }
}
