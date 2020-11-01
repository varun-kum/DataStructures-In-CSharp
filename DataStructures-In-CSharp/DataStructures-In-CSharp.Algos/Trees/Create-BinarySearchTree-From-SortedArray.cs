using DataStructures_In_CSharp.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_In_CSharp.Algos.Trees
{
    /// <summary>
    /// Create a Minimal Binary Search Tree from and a Sorted Array.
    /// </summary>
    public class Create_Minimal_BinarySearchTree_From_SortedArray
    {
        public Node<int> CreateMinimalBST(int[] array)
        {
            return CreateMinimalBST(array, 0, array.Length - 1);
        }
        public Node<int> CreateMinimalBST(int[] array, int start, int end)
        {
            if (end < start)
                return null;

            int mid = (start + end) / 2;
            Node<int> node = new Node<int>(array[mid]);
            node.Left = CreateMinimalBST(array, start, mid - 1);
            node.Right = CreateMinimalBST(array, mid + 1, end);
            return node;
        }
    }
}

