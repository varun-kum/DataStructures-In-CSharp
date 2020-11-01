﻿using DataStructures_In_CSharp.Algos.Trees;
using DataStructures_In_CSharp.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_In_CSharp.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateLinkedListBFS();
        }

        public static void CreateLinkedListDFS()
        {
            Tree<string> tree = DataStructures_In_CSharpTests.Mock.Trees.GetSampleTree();
            Create_LinkedList_Of_AdjacentNodes_BinaryTree_DFS treeClass = new Create_LinkedList_Of_AdjacentNodes_BinaryTree_DFS();
            List<LinkedList<Node<string>>> lists = treeClass.CreateLinkedList(tree.root);
        }

        public static void CreateLinkedListBFS()
        {
            Tree<string> tree = DataStructures_In_CSharpTests.Mock.Trees.GetSampleTree();
            Create_LinkedList_Of_AdjacentNodes_BinaryTree_DFS treeClass = new Create_LinkedList_Of_AdjacentNodes_BinaryTree_DFS();
            List<LinkedList<Node<string>>> lists = treeClass.CreateLinkedList(tree.root);
        }
    }
}