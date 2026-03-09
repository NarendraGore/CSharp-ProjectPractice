using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice.OOP
{
    internal class OverLoadingExample
    {
        internal void Add(int a, int b) {

            Console.WriteLine(a + b);

        }
        internal void Add(int a, int b, int c)
        {

            Console.WriteLine(a + b+c);

        }
        internal void Add(float a, float b)
        {

            Console.WriteLine(a + b);

        }

    }
}
