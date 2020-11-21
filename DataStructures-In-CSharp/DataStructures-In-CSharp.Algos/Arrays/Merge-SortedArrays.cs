using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_In_CSharp.Algos.Arrays
{
    public class Merge_SortedArrays
    {
        /// <summary>
        /// Merge two sorted arrays
        /// </summary>
        /// <param name="nums1">Integer Sorted Array 1</param>
        /// <param name="nums2">Integer Sorted Array 2</param>
        /// <returns></returns>
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] nums = new int[nums1.Length + nums2.Length];

            int i = nums1.Length - 1;
            int j = nums2.Length - 1;
            int counter = i + j + 1;
            while (counter > 0)
            {
                if (nums1[i] > nums2[j])
                    nums[counter--] = nums1[i--];
                else
                    nums[counter--] = nums2[j--];
            }

            int mid = nums.Length / 2;
            if (nums.Length % 2 == 0)
                return (nums[mid] + nums[mid - 1]) / 2;

            return (double)nums[mid];
        }
    }
}
