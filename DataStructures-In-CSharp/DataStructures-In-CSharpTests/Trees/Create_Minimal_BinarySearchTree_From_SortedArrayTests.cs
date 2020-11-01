using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures_In_CSharp.Algos.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures_In_CSharp.Trees;

namespace DataStructures_In_CSharp.Algos.Trees.Tests
{
    [TestClass()]
    public class Create_Minimal_BinarySearchTree_From_SortedArrayTests
    {
        [TestMethod()]
        public void CreateMinimalBSTTest()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Create_Minimal_BinarySearchTree_From_SortedArray tree = new Create_Minimal_BinarySearchTree_From_SortedArray();
            Node<int> root = tree.CreateMinimalBST(array);
            Assert.AreEqual(root.Left.Name, 5);
        }
    }
}