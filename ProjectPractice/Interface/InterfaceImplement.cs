using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice.Interface
{
    internal class InterfaceImplement:IFirst,ISecond
    {

         void IFirst.fun1() {
            Console.WriteLine("Fun1");
        }
         void IFirst.fun2() {
            Console.WriteLine("Fun2");
        }

        void ISecond.fun1()
        {
            Console.WriteLine("Fun1");
        }
        void ISecond.fun2()
        {
            Console.WriteLine("Fun2");
        }
         void ISecond.fun3() {
            Console.WriteLine("Fun3");
        }

    }
}
