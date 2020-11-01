using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_In_CSharp.Trees
{
    public class Tree<T>
    {
        public Node<T> root;

        public Tree(Node<T> _root)
        {
            root = _root;
        }
    }
}
