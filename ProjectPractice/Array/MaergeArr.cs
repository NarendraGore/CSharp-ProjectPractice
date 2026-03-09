using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice.Array
{
    internal class MaergeArr
    {
        static void Main()
        {
            int[] arr1 = { 1, 3, 6};
            int[] arr2 = { 2,4,6,7,8,9,8,5,5,5,45,4 };
            int[] merged = new int[arr1.Length+arr2.Length];
            int i = 0, j = 0, k = 0;

            while (i<arr1.Length && j<arr2.Length) {
                if (arr1[i] < arr2[j])
                {
                    merged[k] = arr1[i];
                    i++;

                }
                else { 
                merged[k] = arr2[j];
                    j++;
                }
                k++;
            
            }

            while (i < arr1.Length) { 
            merged[k] = arr1[i];
                i++;
                k++;
            }

            while (j < arr2.Length) {
                merged[k] = arr2[j];
                j++;
                k++;
            }

            Console.WriteLine("Merged Array:");
            foreach(int num in merged) { 
               Console.WriteLine(num);
            }
        
        }
    }
}
