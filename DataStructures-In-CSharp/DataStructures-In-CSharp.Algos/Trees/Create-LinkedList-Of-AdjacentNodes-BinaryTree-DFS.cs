using DataStructures_In_CSharp.Trees;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_In_CSharp.Algos.Trees
{
    public class Create_LinkedList_Of_AdjacentNodes_BinaryTree_DFS
    {
        private void CreateLinkedList(Node<string> root, List<LinkedList<Node<string>>> lists, int Level)
        {
            if (root == null) return;

            LinkedList<Node<string>> list = new LinkedList<Node<string>>();
            if (lists.Count == Level) //Current Level nodes not added to list yet
            {
                list = new LinkedList<Node<string>>();
                lists.Add(list);
            }
            else
            {
                list = lists[Level];
            }
            list.AddFirst(root);
            CreateLinkedList(root.Left, lists, Level + 1);
            CreateLinkedList(root.Right, lists, Level + 1);
        }

        public List<LinkedList<Node<string>>> CreateLinkedList(Node<string> root)
        {
            List<LinkedList<Node<string>>> lists = new List<LinkedList<Node<string>>>();
            CreateLinkedList(root, lists, 0);
            return lists;
        }
    }
}
