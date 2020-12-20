using DataStructures_In_CSharp.Algos.Sorting;
using DataStructures_In_CSharp.Algos.Trees;
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
        static int MyAtoi(string s)
        {
            StringBuilder str = new StringBuilder();
            str.Append("");

            bool isNegative = false;
            bool foundNumeric = false;
            Int32 ret = 0;
            StringBuilder num = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                    continue;
                else if (s[i] == '-')
                    isNegative = true;
                else if ((int)s[i] < 0 || (int)s[i] > 9)
                {
                    if (!foundNumeric)
                        return 0;
                    else
                        break;
                }
                else
                {
                    foundNumeric = true;
                    num.Append(s[i]);
                }
            }

            ret = Convert.ToInt32(num);
            if (isNegative)
                ret = -1 * ret;
            return ret;
        }
        static void Main(string[] args)
        {
            int val = MyAtoi("42");
            //int[] arr = { 20, 35, -15, 7, -22, 30, 11, 100, -1000 };

            //MergeSort sort = new MergeSort();
            //int[] sortedarray = sort.Sort(arr);

            int[] arr = { 20, 35, 15, 7, -22, 30, 11 };

            QuickSort sort = new QuickSort();
            int[] sortedarray = sort.Sort(arr);


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
