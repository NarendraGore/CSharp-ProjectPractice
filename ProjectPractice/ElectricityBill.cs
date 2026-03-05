using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice
{
    internal class ElectricityBill
    {
        static void Main() {
            /*WAP to calculate electricity bill where unit price, total consumption, the
            extra load will be entered by the users?*/

            double unitPrice, totalConsumption, extraLoad, totalBill;

            Console.Write("Enter The Unit Price: ");
            unitPrice = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter The Total COnsumpiton of units: ");
            totalConsumption = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Extra Load");
            extraLoad = Convert.ToDouble(Console.ReadLine());

            totalBill = (unitPrice * totalConsumption) + extraLoad;

            Console.WriteLine("Total Bill is: {0}",totalBill);

        }
    }
}
