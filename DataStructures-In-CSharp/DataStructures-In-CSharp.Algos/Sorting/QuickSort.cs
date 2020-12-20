using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_In_CSharp.Algos.Sorting
{
    /// <summary>
    /// Divide and Conquer Algo (Recursive)
    /// In Place Algo - No temp array
    /// Not Stable Algorithm
    /// Time Complexity: Ω(n log(n)) | Θ(n log(n)) | O(n^2)	
    /// Space Complexity: O(1)
    /// </summary>
    public class QuickSort
    {
        /// <summary>
        /// Public Method to call Quick Sort.
        /// </summary>
        /// <param name="arr">Input Integer Array</param>
        /// <returns></returns>
        public int[] Sort(int[] arr)
        {
            QuickSortArray(arr, 0, arr.Length);
            return arr;
        }

        /// <summary>
        /// Method to perform Quick Sort
        /// </summary>
        /// <param name="arr">Input Integer Array</param>
        /// <param name="start">Start Index</param>
        /// <param name="end">End Index</param>
        void QuickSortArray(int[] arr, int start, int end)
        {
            if (end - start < 2)
                return;

            int pivotIndex = Partition(arr, start, end);
            QuickSortArray(arr, start, pivotIndex);
            QuickSortArray(arr, pivotIndex+1, end);
        }

        //Using First element as Pivot
        int Partition(int[] arr, int start, int end)
        {
            int pivot = arr[start];
            int i = start;
            int j = end;

            while (i < j)
            {
                //Empty Loop Body
                while (i < j && arr[--j] >= pivot);
                if(i<j)
                {
                    arr[i] = arr[j];
                }

                //Empty Loop Body
                while (i < j && arr[++i] <= pivot) ;
                if (i < j)
                {
                    arr[j] = arr[i];
                }
            }

            arr[j] = pivot;
            return j;
        }
    }
}
