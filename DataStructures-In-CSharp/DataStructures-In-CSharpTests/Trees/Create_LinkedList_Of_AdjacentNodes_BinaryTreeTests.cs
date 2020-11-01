using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures_In_CSharp.Trees;
using DataStructures_In_CSharp.Algos.Trees;
using DataStructures_In_CSharpTests.Mock;

namespace DataStructures_In_CSharpTests.Trees
{
    [TestClass()]
    class Create_LinkedList_Of_AdjacentNodes_BinaryTree_DFSTests
    {
        [TestMethod()]
        public void CreateLinkedListTest()
        {
            Tree<string> tree = DataStructures_In_CSharpTests.Mock.Trees.GetSampleTree();
            Create_LinkedList_Of_AdjacentNodes_BinaryTree_DFS treeClass = new Create_LinkedList_Of_AdjacentNodes_BinaryTree_DFS();
            List<LinkedList<Node<string>>> lists = treeClass.CreateLinkedList(tree.root);
            Assert.AreEqual(lists.Count, 3);
            Assert.AreEqual(lists[2].Count, 4);
        }
    }
}
