using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice
{
    internal class GraceMark
    {
        /*WAP to display the subject mark of the student which will be entered by the user's if the entered 
        subject mark is eligible for grace then display mark including grace mark otherwise
        actual mark will display.*/
        static void Main()
        {
            double marks;
            Console.WriteLine("Enter The marks of Subject to check eligibilty for the Grace Marks:");
            marks = Convert.ToDouble(Console.ReadLine());

            if (marks > 28 && marks < 33)
            {
                Console.WriteLine("You are elegible for Grace Marks");
                double grace = 33 - marks;
                Console.WriteLine("You Got the Grace of {0} marks.", grace);

            }
            else
            {
                Console.WriteLine("You are passed without grace marks.");
            }
        }
    }
}