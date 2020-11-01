using DataStructures_In_CSharp.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_In_CSharpTests.Mock
{
    public class Trees
    {
        public static Tree<string> GetSampleTree()
        {
            Node<string> root = new Node<string>("A");
            Tree<string> tree = new Tree<string>(root);
            root.Left = new Node<string>("B");
            root.Right = new Node<string>("C");
            
            root.Left.Left = new Node<string>("D");
            root.Left.Right= new Node<string>("E");

            root.Right.Left = new Node<string>("F"); 
            root.Right.Right = new Node<string>("G");
            return tree;
        }
    }
}
