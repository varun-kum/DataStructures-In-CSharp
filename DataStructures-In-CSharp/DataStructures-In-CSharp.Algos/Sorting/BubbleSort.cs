using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_In_CSharp.Algos.Sorting
{
    /// <summary>
    /// Complexity: Ω(n) | Θ(n^2) | O(n^2)
    /// Space Complexity: O(1)
    /// </summary>
    public class BubbleSort
    {
        /// <summary>
        /// Public Method to call Bubble Sort.
        /// </summary>
        /// <param name="arr">Input Integer Array</param>
        /// <returns></returns>
        public int[] Sort(int[] arr)
        {
            for (int lastunsortedIndex = arr.Length-1; lastunsortedIndex > 0; lastunsortedIndex--)
            {
                for (int j = 0; j < lastunsortedIndex; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Common.Swap(arr, j, j+1);
                    }
                }
            }
            return arr;
        }
    }
}
