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
    public class InsertionSort
    {
        /// <summary>
        /// Public Method to call Insertion Sort.
        /// </summary>
        /// <param name="arr">Input Integer Array</param>
        /// <returns></returns>
        public int[] Sort(int[] arr)
        {
            for (int firstunsortedIndex = 1; firstunsortedIndex < arr.Length; firstunsortedIndex++)
            {
                int element = arr[firstunsortedIndex];

                int j;
                for (j = firstunsortedIndex; j > 0 && arr[j - 1] > element; j--)
                {
                    arr[j] = arr[j - 1];
                }
                arr[j] = element;
            }
            return arr;
        }
    }
}
