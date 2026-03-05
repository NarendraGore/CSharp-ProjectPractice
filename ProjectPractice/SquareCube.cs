using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice
{
    internal class SquareCube
    {
        static void Main() {
            int number, square, cube;

            Console.WriteLine("Write a Number To Calclulate Square and Cube");

            number = Convert.ToInt32(Console.ReadLine());

            square = number * number;
            cube = square * number;

            Console.WriteLine("Square of Given Number is {0} & Cube of Given Number is {1}",square,cube);
        
        }
    }
}
