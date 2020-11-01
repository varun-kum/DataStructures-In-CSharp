using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_In_CSharp.Trees
{
    public class Node<T>
    {
        public T Name;
        public Node<T> Left;
        public Node<T> Right;

        public Node(T name)
        {
            Name = name;
        }
    }
}
