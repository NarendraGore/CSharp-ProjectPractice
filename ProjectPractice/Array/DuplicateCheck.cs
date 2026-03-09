using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice.Array
{
    internal class DuplicateCheck
    {
        static void Main() {

            int[] arr = { 1, 5, 2, 1, 3, 2,5,7,9,8,7,9,8 };
            Console.Write("Duplicates Element are:");

            for (int i = 0; i < arr.Length; i++) {
                for (int j = i + 1; j < arr.Length; j++) {

                    if (arr[i] == arr[j]) {
                        
                        Console.Write(arr[i]+", ");
                        break;
                    
                    }
                }
            
            }
        }
    }
}
