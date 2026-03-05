using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice
{
    internal class SI
    {
        float p, r, t, si;

        internal void CalcSI() {
            p = 12000;
            r = 1.2f;
            t = 2.2f;
            si = (p * r * t) / 100;
            Console.WriteLine("Result is {0}" , si);
        }
    }
}
