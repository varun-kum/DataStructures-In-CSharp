using DataStructures_In_CSharp.Trees;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_In_CSharp.Algos.Trees
{
    public class Create_LinkedList_Of_AdjacentNodes_BinaryTree_BFS
    {
        private void CreateLinkedList(Node<string> root, List<LinkedList<Node<string>>> lists)
        {
            if (root == null) return;

            LinkedList<Node<string>> current = new LinkedList<Node<string>>();
            current.AddFirst(root);

            while (current.Count>0)
            {
                lists.Add(current);

                LinkedList<Node<string>> parents= new LinkedList<Node<string>>();
                parents = current;
                current = new LinkedList<Node<string>>();

                foreach(Node<string> parent in parents)
                {
                    if (parent.Left != null)
                        current.AddFirst(parent.Left);
                    if (parent.Right != null)
                        current.AddFirst(parent.Right);
                }
            }
        }

        public List<LinkedList<Node<string>>> CreateLinkedList(Node<string> root)
        {
            List<LinkedList<Node<string>>> lists = new List<LinkedList<Node<string>>>();
            CreateLinkedList(root, lists);
            return lists;
        }
    }
}
