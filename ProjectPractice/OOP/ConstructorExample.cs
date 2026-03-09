using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice.OOP
{
    internal class ConstructorExample
    {
       static int x, y;
        int a, b;
        static ConstructorExample() {
            x = 100;
            y = 200;
            Console.WriteLine("Static Constructor Example");
            Console.WriteLine(x-y);
        
        }
        internal ConstructorExample() {
            a = 100;
            b = 200;
        Console.WriteLine("Default Constructor");
            Console.WriteLine(a+b);
        }

        internal ConstructorExample(int a, int b) {
            this.a = a;
            this.b = b;
            Console.WriteLine("Parameterized Constructor");
            Console.WriteLine(a*b);
        
        }
        internal ConstructorExample(ConstructorExample c)
        {
            this.a = c.a;
            this.b = c.b;
            Console.WriteLine("Copy Constructor");
            Console.WriteLine(a * b);

        }
    }
}
