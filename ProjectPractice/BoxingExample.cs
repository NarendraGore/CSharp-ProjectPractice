using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice
{
    internal class BoxingExample
    {

        internal void boxingfun() {
            int a = 10;
            object b;
            b = a;
            Console.WriteLine(b);
        }
        internal void Unboxingfun()
        {
            object a = 10;
            int b;
            b = (int)a;
            Console.Write(b);
        }
    }
}
