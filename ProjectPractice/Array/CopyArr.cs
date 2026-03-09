using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice.Array
{
    internal class CopyArr
    {
        /*
         Copying an Array** * **Task:** Given an array `A`, create a second array `B` of the same size 
        and copy all elements from `A` to `B` manually using a loop.
        Goal:** Understand that arrays are reference types and how to replicate data.*/

        static void Main() {
            int[] arr1 = {10,20,30,40,50};
            int[] arr2 = new int[arr1.Length] ;

            for (int i = 0; i < arr1.Length; i++) { 
            arr2[i] = arr1[i];
            }

            foreach (int i in arr2) { 
                Console.WriteLine(i);
            }
        }
    }
}
