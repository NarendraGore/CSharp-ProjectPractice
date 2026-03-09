using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice.Array
{
    internal class ArrReverse
    {
        /*
         Array Reversal (In-Place)** * **Task:** Reverse the order of elements in an array **without**
        creating a new array.
        *Goal:** Master the "Swap" logic using a `temp` variable.*/

        static void Main() {
            Console.Write("Array :");
            int[] arr = { 1, 23, 56, 654, 65, 3, 61, 65, 4 };
            foreach (int i in arr) { 
            Console.Write( i+", ");

            }
            Console.WriteLine();

            int start = 0;
            int end = arr.Length-1;
            for (int i = 0; i < end; i++) { 
                        
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
            Console.Write("Reverse Array:");

            foreach (int i in arr) {
                Console.Write(i+", ");
            
            }
            Console.WriteLine();

        }
    }
}
