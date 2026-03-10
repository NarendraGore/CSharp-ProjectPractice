using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice.OOP.Overhiding
{
    internal class GSTBill:Bill
    {
        public double CalcBill(int amount) {
            return amount + amount * 0.18f;
        }
    }
}
