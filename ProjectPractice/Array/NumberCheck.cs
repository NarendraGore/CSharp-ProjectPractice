using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice.Array
{
    internal class NumberCheck
    {
        static void Main()
        {
            int[] arr = { 1, 12, 15, 30, 45, 69, 56, 56, 0, 65, 0, 560, 65, 6, 5, 56, 65 };

            int number;
            Console.WriteLine("Enter a Number:");
            number = Convert.ToInt32(Console.ReadLine());
            bool isnumber = false; 

            for (int i = 0; i < arr.Length; i++) {

                if (arr[i] == number)
                {

                    Console.WriteLine("number is found at index:"+i);
                    isnumber = true;
                  
                }
              
            
            }

            if (isnumber == false) {
                Console.WriteLine("Number is not found in array");
            }
           
            
            }
    }
}
