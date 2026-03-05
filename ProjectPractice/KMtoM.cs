using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice
{
    internal class KMtoM
    {
        //WAP to convert km to meter?

        static void Main() {

            double distance, outputinM;

           

            Console.WriteLine("Enter the Disatnce in KM");
            distance = Convert.ToDouble(Console.ReadLine());

            outputinM = distance * 1000;

            Console.WriteLine("{0}KM distance in Meter is {1}",distance, outputinM);
        }
    }
}
