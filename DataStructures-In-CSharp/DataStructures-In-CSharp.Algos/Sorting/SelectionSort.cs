using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_In_CSharp.Algos.Sorting
{
    /// <summary>
    /// Complexity: Ω(n^2) | Θ(n^2) | O(n^2)
    /// Space Complexity: O(1)
    /// </summary>
    public class SelectionSort
    {
        /// <summary>
        /// Public Method to call Selection Sort.
        /// </summary>
        /// <param name="arr">Input Integer Array</param>
        /// <returns></returns>
        public int[] Sort(int[] arr)
        {
            for (int lastunsortedIndex = arr.Length - 1; lastunsortedIndex > 0; lastunsortedIndex--)
            {
                int max = 0;

                for (int j = 0; j <= lastunsortedIndex; j++)
                {
                    if (arr[j] > arr[max])
                    {
                        max = j;
                    }
                }
                Common.Swap(arr, max, lastunsortedIndex);
            }
            return arr;
        }
    }
}
