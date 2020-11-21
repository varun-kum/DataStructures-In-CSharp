using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_In_CSharp.Algos.Arrays
{
    class Median_of_two_SortedArrays_BinarySearch
    {
        /*
         Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.

            Solution: Merge the two arrays and get median.
                        Not an optimum solution
            Compelxity: O(log(min(m,n)))
            Space complexity: O(1)
        */
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if (nums2.Length < nums1.Length)
                return FindMedianSortedArrays(nums2, nums1);

            double result = 0;
            int X = nums1.Length;
            int Y = nums2.Length;
            int start = 0;
            int end = X;

            while (start <= end)
            {
                //Partition the two arrays into 2 parts each such that total number of all lefts are equal to rights 
                //in case of even array or left-1=right in case of odd arrays
                int PartitionX = (start + end) / 2;
                int PartitionY = (X + Y + 1) / 2 - PartitionX;

                //Set MaxLeft to -infinity in case of all lefts are smaller then rights.
                int MaxLeftX = (PartitionX == 0) ? int.MinValue : nums1[PartitionX - 1];
                int MaxLeftY = (PartitionY == 0) ? int.MinValue : nums2[PartitionY - 1];

                int MinRightX = (PartitionX == X) ? int.MaxValue : nums1[PartitionX];
                int MinRightY = (PartitionY == Y) ? int.MaxValue : nums2[PartitionY];

                //If the Lefts are smalled then the rights of both arrays.
                if (MaxLeftX <= MinRightY && MaxLeftY <= MinRightX)
                {
                    if ((X + Y) % 2 == 0)
                    {
                        return (double)((Math.Max(MaxLeftX, MaxLeftY) +
                                          Math.Min(MinRightX, MinRightY)) / 2);
                    }
                    else
                    {
                        return (double)Math.Max(MaxLeftX, MaxLeftY);
                    }
                }
                else if (MaxLeftX > MinRightY)
                {
                    end = PartitionX - 1;
                }
                else
                {
                    start = PartitionX + 1;
                }
            }
            return result;
        }
    }
}
