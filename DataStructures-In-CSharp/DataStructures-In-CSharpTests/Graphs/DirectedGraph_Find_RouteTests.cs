using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures_In_CSharp.Graphs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures_In_CSharp.Algos.Graphs;
using DataStructures_In_CSharpTests.Mock;

namespace DataStructures_In_CSharp.Graphs.Tests
{
    [TestClass()]
    public class DirectedGraph_Find_RouteTests
    {
        [TestMethod()]
        public void SearchTest_Exist()
        {
            Graph graph = DataStructures_In_CSharpTests.Mock.Graphs.GetSampleGraph();
            DirectedGraph_Find_Route finder = new DirectedGraph_Find_Route();
            bool result = finder.Search(graph, graph.nodes[0], graph.nodes[4]);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void SearchTest_NotExist()
        {
            Graph graph = DataStructures_In_CSharpTests.Mock.Graphs.GetSampleGraph();
            DirectedGraph_Find_Route finder = new DirectedGraph_Find_Route();
            bool result = finder.Search(graph, graph.nodes[0], graph.nodes[5]);
            Assert.IsFalse(result);
        }
    }
}