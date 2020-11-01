using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_In_CSharp.Algos.Sorting
{
    public class SelectionSort
    {
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
