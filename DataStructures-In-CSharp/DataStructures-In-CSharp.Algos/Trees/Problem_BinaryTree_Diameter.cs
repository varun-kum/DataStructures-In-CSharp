using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_In_CSharp.Algos.Trees
{/*
  Compute the diameter of the tree. 
  The diameter of a binary tree is the length of the longest path between any two nodes in a tree. 
  (This path may or may not pass through the root.)

    Example:
    Given a binary tree
              1
             / \
            2   3
           / \     
          4   5    
    Return 3, which is the length of the path [4,2,1,3] or [5,2,1,3].

    Note: The length of path between two nodes is represented by the number of edges between them. 
   */
    public class Problem_BinaryTree_Diameter
    {
        int ans;
        /// <summary>
        /// Public method to return the depth of the tree.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int DiameterOfBinaryTree(DataStructures_In_CSharp.Trees.Node<int> root)
        {
            depth(root);
            return ans - 1;
        }

        /// <summary>
        /// Method to ge the depth of the nodes
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public int depth(DataStructures_In_CSharp.Trees.Node<int> node)
        {
            if (node == null) return 0;
            int L = depth(node.Left);
            int R = depth(node.Right);
            ans = Math.Max(ans, L + R + 1);
            return Math.Max(L, R) + 1;
        }
    }
}
