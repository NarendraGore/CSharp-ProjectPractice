using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice.OOP.AccessSpecifiers
{
    internal class AccessSpecifiers
    {
        private void fun1() {

            Console.WriteLine("Private fun1");
        
        }
        internal void fun2() {
            Console.WriteLine("Internal fun2");

        }

        protected void fun3() {
            Console.WriteLine("Protected fun3");

        }

        protected internal void fun4() {
            Console.WriteLine("Protected Internal fun4");


        }

        public void fun5() {
            Console.WriteLine("Public fun5");


        }

       
    }
}
