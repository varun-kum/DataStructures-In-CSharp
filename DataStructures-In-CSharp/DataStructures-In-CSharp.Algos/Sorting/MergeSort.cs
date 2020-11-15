using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_In_CSharp.Algos.Sorting
{
    public class MergeSort
    {
        public int[] Sort(int[] arr)
        {
            MergeSortArray(arr, 0, arr.Length);
            return arr;
        }

        void MergeSortArray(int[] arr, int start, int end)
        {
            if (end - start < 2)
                return;

            int mid = (start + end) / 2;

            MergeSortArray(arr, start, mid);
            MergeSortArray(arr, mid, end);
            Merge(arr, start, mid, end);
        }

        void Merge(int[] arr, int start, int mid, int end)
        {
            if (arr[mid - 1] <= arr[mid])
                return;

            int lIndex = start;
            int rIndex = mid;
            int tempIndex = 0;

            int[] tempArray = new int[end + start];

            while (lIndex < mid && rIndex < end)
            {
                tempArray[tempIndex++] = (arr[lIndex] <= arr[rIndex]) ? arr[lIndex++] : arr[rIndex++];
            }

            System.Array.Copy(arr, lIndex, arr, start + tempIndex, mid - lIndex);
            System.Array.Copy(tempArray, 0, arr, start, tempIndex);
        }
    }
}