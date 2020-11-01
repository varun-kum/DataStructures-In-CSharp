using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_In_CSharp.Graphs
{
    public class Graph
    {
        public Node[] nodes;

        public Graph()
        {
        }
        public Graph(Node[] _nodes)
        {
            nodes = _nodes;
        }
    }
}
