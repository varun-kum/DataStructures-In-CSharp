using DataStructures_In_CSharp.Graphs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_In_CSharp.Algos.Graphs
{
    public class DirectedGraph_Find_Route
    {
        public bool Search(Graph graph, Node start, Node end)
        {
            if (start == end)
                return true;

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(start);

            while (queue.Count() > 0)
            {
                Node parent = queue.Dequeue();
                if (parent.Childrens != null)
                {
                    foreach (Node node in parent.Childrens)
                    {
                        if (node.state == State.UnVisited)
                        {
                            if (node == end)
                                return true;
                            else
                            {
                                node.state = State.Visiting;
                                queue.Enqueue(node);
                            }
                        }
                    }
                    parent.state = State.Visited;
                }
            }
            return false;
        }
    }
}