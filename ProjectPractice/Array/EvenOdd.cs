using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice.Array
{
    internal class EvenOdd
    {
        static void Main()
        {

            /* Even & Odd Splitter** * **Task:** Given one array of 10 numbers, create two new arrays: 
               one to store only the even numbers and one for the odd numbers.
               Goal:** Practice dynamic filtering and working with multiple arrays*/
            int[] array = { 10, 15, 20, 33, 40, 55, 60, 71, 80, 91 };
            int[] evenarr = new int[array.Length];
            int[] oddarr = new int[array.Length];
            int evenIndex = 0;
            int oddIndex = 0;


            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    evenarr[evenIndex] = array[i];
                    evenIndex++;

                }
                else
                {
                    oddarr[oddIndex] = array[i];
                    oddIndex++;
                }

            }

            Console.WriteLine("Printing Even Array:");

            for (int i = 0; i < evenIndex; i++)
            {

                Console.Write(evenarr[i] + ", ");

            }
            Console.WriteLine();
            Console.WriteLine("Printing Odd Array:");
            for (int i = 0; i < oddIndex; i++)
            {
                Console.Write(oddarr[i] + ", ");

            }
            Console.WriteLine();
        }
    }
}