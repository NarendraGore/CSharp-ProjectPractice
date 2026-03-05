using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;

namespace ProjectPractice
{
    internal class DataType
    {

        public void PDataType() {
            //1byte = 8bit
            int a = 10; //4byte
            float b = 20.5f;//4byte
            double c = 25.98;//8byte
            char d = 'A';//2byte
            bool e = false; //1byte
            string f = "Hello";
            byte g = 1;

            Console.WriteLine("a ={0}, b={1},c={2}, d={3}, e={4}, f={5},g={6}", a, b, c, d, e, f, g);

        }

        public void DDataType() {
            Int16 a = 32;
            Double b = 64;
            Byte c = 128;
            Boolean d = false;
            Char ch = 'c';
            String e = null;
            Object o = 10;

            Console.WriteLine("a ={0}, b={1},c={2}, d={3}, ch={4}, e={5},o={6}", a, b, c, d, e, ch, o);

        }
    }
}
