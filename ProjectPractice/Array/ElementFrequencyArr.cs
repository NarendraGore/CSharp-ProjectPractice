using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice.Array
{
    internal class ElementFrequencyArr
    {
        static void Main() {
        int[] arr = { 1, 2, 1, 3, 2, 1 };
            bool[] visited = new bool[arr.Length];
            
            for (int i = 0; i < arr.Length; i++) {
                if (visited[i]) {// if false then Continue;
                    continue;
                }

                int count = 1;

                for (int j = i + 1; j < arr.Length; j++) {
                    if (arr[i] == arr[j]) {

                        visited[j] = true;
                        count++;
                    }
                }
                Console.WriteLine(arr[i]+"occurs"+count+"times");
            }



        }
    }
}
