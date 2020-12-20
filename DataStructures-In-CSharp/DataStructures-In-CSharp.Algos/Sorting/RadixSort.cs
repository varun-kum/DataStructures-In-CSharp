using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_In_CSharp.Algos.Sorting
{
    /// <summary>
    /// All Values has same radix and width - Radix for Decimal System is 10 (0-9), Binary is 2 (0,1), Alphabet (a-z)
    /// Width is Length ("Hello" is 5, 100 -3)
    /// Data should be integer or strings (Cant sort Floats)
    /// Uses Stable Counting Sorting for each postion (10's, 100's etc)
    /// Stable Algo
    /// Complexity: Ω(nk) | Θ(nk) | O(nk)
    /// Space Complexity: O(n+k)
    /// </summary>
    public class RadixSort
    {

        /// <summary>
        /// Public Method to call Counting Sort.
        /// </summary>
        /// <param name="arr">Input Integer Array</param>
        /// <param name="min">Minimum number in the range</param>
        /// <param name="max">Maximum number in the range</param>
        /// <returns></returns>
        public int[] Sort(int[] arr, int radix, int width)
        {
            RadixSortArray(arr, radix, width);
            return arr;
        }
        /// <summary>
        /// Method to perform Counting Sort
        /// </summary>
        /// <param name="arr">Input Integer Array</param>
        /// <param name="radix">Radix of the Integer</param>
        /// <param name="width">The Width of the Integer</param>
        void RadixSortArray(int[] arr, int radix, int width)
        {
            for (int i = 0; i < width; i++)
            {
                RadixSingleSortArray(arr, i, radix);
            }
        }

        /// <summary>
        /// Method to perform radix sort for each postion
        /// </summary>
        /// <param name="arr">Input Integer Array - {2345, 3442,4535, 3534, 2323, 3455}</param>
        /// <param name="position">Postion of the digit in the integer</param>
        /// <param name="radix">Radix of the Integer</param>
        void RadixSingleSortArray(int[] arr, int position, int radix)
        {
            int count = arr.Length;
            int[] countArray = new int[radix];

            //Performing CountingSort for the Array.
            foreach (int value in arr)
            {
                countArray[GetDigit(position, value, radix)]++;
            }
            //countArray = {0,0,1,1,1,3,0,0,0,0}

            //Adjust the CountArray to sumup values at each level. (To Stablize).
            for (int j = 1; j < radix; j++)
            {
                countArray[j] += countArray[j - 1];
            }
            //countArray = {0,0,1,2,3,6,6,6,6,6}

            // Processing elements from right to left to store in their correct positions in Temp Array (To Stablize)
            int[] temp = new int[count];
            for (int tempIndex = count - 1; tempIndex >= 0; tempIndex--)
            {
                temp[--countArray[GetDigit(position, arr[tempIndex], radix)]] = arr[tempIndex];
            }
            //temp = { 3442, 2323, 3534, 2345, 4535, 3455}
            //countArray = {0,0,0,1,2,3,6,6,6,6}

            //Storing the elements from temp array back to original Array.
            for (int index=0;index<count;index++)
            {
                arr[index] = temp[index];
            }
        }

        /// <summary>
        /// Method to get the digit of each place.
        /// </summary>
        /// <param name="position">Position of digit</param>
        /// <param name="value">The number from which the digit to be extracted</param>
        /// <param name="radix">Radix</param>
        /// <returns></returns>
        int GetDigit(int position, int value, int radix)
        {
            return value / (int)Math.Pow(radix, position) % radix;
        }
    }
}
