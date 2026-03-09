using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice.OOP
{
    internal class MemberFunction
    {
      
        //1) No Param | No Return Type
        internal void fun() {
            Console.WriteLine("No parameter and No return type function");
        
        
        }
        //2) No Param | Return Type
        internal int fun2() {
            Console.WriteLine("No parameter and  return type function");

            int num = 10;
            return num * num;
        }

        //3) Param | No Return Type
        internal void fun3(int num1) {
        int square = num1*num1;
            Console.WriteLine(" parameter and  No return type function");
            Console.WriteLine("Square:"+square);
        }

        //4) Param | Return Type
        internal int fun4(int num) {
            int square = num * num;
            Console.WriteLine(" parameter and  return type function");

            return square;
                }


    }
}
