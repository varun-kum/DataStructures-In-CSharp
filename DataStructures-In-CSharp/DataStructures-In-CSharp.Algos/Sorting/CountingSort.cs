using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_In_CSharp.Algos.Sorting
{
    /// <summary>
    /// Linear Type as make assumptions on data length
    /// Not a Stable Algo
    ///  Should not be used if the Range is much bigger then the Size of Array
    ///  Complexity: Ω(n+k)	| Θ(n+k) | O(n+k)
    ///  Space Complexity: O(k)
    /// </summary>
    public class CountingSort
    {
        /// <summary>
        /// Public Method to call Counting Sort.
        /// </summary>
        /// <param name="arr">Input Integer Array</param>
        /// <param name="min">Minimum number in the range</param>
        /// <param name="max">Maximum number in the range</param>
        /// <returns></returns>
        public int[] Sort(int[] arr, int min, int max)
        {
            CountingSortArray(arr, min, max);
            return arr;
        }

        /// <summary>
        /// Method to perform Counting Sort
        /// </summary>
        /// <param name="arr">Input Integer Array</param>
        /// <param name="min">Minimum number in the range</param>
        /// <param name="max">Maximum number in the range</param>
        void CountingSortArray(int[] arr, int min, int max)
        {
            int[] CountingArray = new int[max - min + 1];

            //Looping through the original array to store the counts of each number in the CountingArray.
            for (int i = 0; i < arr.Length; i++)
            {
                CountingArray[arr[i] - min]++;
            }

            //Looping through the CountingArray and adding number to original array for all the frequencies.
            int j = 0;
            for (int i = min; i <= max; i++)
            {
                while (CountingArray[i - min] > 0)
                {
                    arr[j++] = i;
                    CountingArray[i-min]--;
                }
            }
        }
    }
}
