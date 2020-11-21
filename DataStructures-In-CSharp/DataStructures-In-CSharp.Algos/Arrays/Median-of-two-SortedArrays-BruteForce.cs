using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_In_CSharp.Algos.Arrays
{
    /*
     Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.

        Solution: Merge the two arrays and get median.
                    Not an optimum solution
        Compelxity: O(n+m)
        Space complexity: O(1)
    */
    public class Median_of_two_SortedArrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if (nums1.Length == 0)
            {
                if (nums2.Length == 0)
                    return (double)0;
                else
                    return GetMedian(nums2);
            }

            if (nums2.Length == 0)
            {
                if (nums1.Length == 0)
                    return (double)0;
                else
                    return GetMedian(nums1);
            }

            int[] nums = new int[nums1.Length + nums2.Length];

            int i = nums1.Length - 1;
            int j = nums2.Length - 1;
            int counter = i + j + 1;
            while (counter >= 0)
            {
                if (i < 0)
                    nums[counter--] = nums2[j--];
                else if (j < 0)
                    nums[counter--] = nums1[i--];
                else if (nums1[i] > nums2[j])
                    nums[counter--] = nums1[i--];
                else
                    nums[counter--] = nums2[j--];
            }

            return GetMedian(nums);
        }

        /// <summary>
        /// Method to get the median.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        double GetMedian(int[] nums)
        {
            if (nums.Length == 1)
                return (double)nums[0];
            if (nums.Length == 2)
                return (double)(nums[0] + nums[1]) / 2;

            int mid = nums.Length / 2;
            if (nums.Length % 2 == 0)
                return (double)(nums[mid] + nums[mid - 1]) / 2;

            return (double)nums[mid];
        }
    }
}
