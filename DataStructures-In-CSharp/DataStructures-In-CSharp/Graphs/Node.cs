using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_In_CSharp.Graphs
{
    public class Node
    {
        public string Name;
        public Node[] Childrens;
        public State state;

        public Node()
        {
            state = State.UnVisited;
        }
    }
}
