using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ProjectPractice
{
  
    public class Hello
    {
        int a, b, c;

        internal void Accept() {
            Console.WriteLine("Enter First Number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            b = Convert.ToInt32(Console.ReadLine());
        }
        internal void Add()
        {
            c = a + b;
            Console.WriteLine("Addition of Two NUmber is"+c);
        }

       internal void Sub() {

            c = a - b;
            Console.WriteLine("SUbtraction of Two Number is"+c);
        }

       internal void Mult() {
            c = a * b;
            Console.WriteLine("Multiplication of Two Number is"+c);
        }

        internal void Div() {
            c = a / b;
            Console.WriteLine("Division of Two Number is"+c);
        }
       
    }
}
