using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_In_CSharpTests.Graphs
{
    /*
    You are given an array of variable pairs equations and an array of real numbers values, where equations[i] = [Ai, Bi] 
    and values[i] represent the equation Ai / Bi = values[i]. Each Ai or Bi is a string that represents a single variable.
    You are also given some queries, where queries[j] = [Cj, Dj] represents the jth query where you must find the answer 
    for Cj / Dj = ?.
    Return the answers to all queries. If a single answer cannot be determined, return -1.0.
    Note: The input is always valid. You may assume that evaluating the queries will not result in division by zero and 
    that there is no contradiction.


    Example 1:
        Input: equations = [["a","b"],["b","c"]], values = [2.0,3.0], queries = [["a","c"],["b","a"],["a","e"],["a","a"],["x","x"]]
        Output: [6.00000,0.50000,-1.00000,1.00000,-1.00000]
        Explanation: 
        Given: a / b = 2.0, b / c = 3.0
        queries are: a / c = ?, b / a = ?, a / e = ?, a / a = ?, x / x = ?
        return: [6.0, 0.5, -1.0, 1.0, -1.0 ]


    Example 2:
        Input: equations = [["a","b"],["b","c"],["bc","cd"]], values = [1.5,2.5,5.0], queries = [["a","c"],["c","b"],["bc","cd"],["cd","bc"]]
        Output: [3.75000,0.40000,5.00000,0.20000]

    Example 3:
        Input: equations = [["a","b"]], values = [0.5], queries = [["a","b"],["b","a"],["a","c"],["x","y"]]
        Output: [0.50000,2.00000,-1.00000,-1.00000]

    Constraints:
        1 <= equations.length <= 20
        equations[i].length == 2
        1 <= Ai.length, Bi.length <= 5
        values.length == equations.length
        0.0 < values[i] <= 20.0
        1 <= queries.length <= 20
        queries[i].length == 2
        1 <= Cj.length, Dj.length <= 5
        Ai, Bi, Cj, Dj consist of lower case English letters and digits.
    */
    public class Problem_EvaluateDivision_UsingGraphs
    {
        public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries)
        {
            Dictionary<string, Dictionary<string, double>> graph = new Dictionary<string, Dictionary<string, double>>();

            // Build the graph from the equations
            for (int i = 0; i < equations.Count; i++)
            {
                string dividend = equations[i][0];
                string divisor = equations[i][1];
                double quo = values[i];

                if (!graph.ContainsKey(dividend))
                    graph.Add(dividend, new Dictionary<string, double>());

                if (!graph.ContainsKey(divisor))
                    graph.Add(divisor, new Dictionary<string, double>());

                graph[dividend].Add(divisor, quo);
                graph[divisor].Add(dividend, 1 / quo);
            }

            // Evaluate each query via bactracking (DFS) by verifying if there exists a path from dividend to divisor
            double[] results = new double[queries.Count];
            for (int i = 0; i < queries.Count; i++)
            {
                string dividend = queries[i][0];
                string divisor = queries[i][1];

                if (!graph.ContainsKey(dividend) && !graph.ContainsKey(divisor))
                    results[i] = -1.0;
                else if (dividend == divisor)
                    results[i] = 1.0;
                else
                {
                    HashSet<string> visited = new HashSet<string>();
                    results[i] = backtrackEvaluate(graph, dividend, divisor, 1, visited);
                }
            }
            return results;
        }

        private double backtrackEvaluate(Dictionary<string, Dictionary<string, double>> graph, String currNode, String targetNode, double accProduct, HashSet<String> visited)
        {
            // mark the visit
            visited.Add(currNode);
            double ret = -1.0;

            Dictionary<string, double> neighbours = new Dictionary<string, double>();

            if (graph.ContainsKey(currNode))
                neighbours = graph[currNode];

            if (neighbours.ContainsKey(targetNode))
                ret = accProduct * neighbours[targetNode];
            else
            {
                foreach (string key in neighbours.Keys)
                {
                    if (visited.Contains(key))
                        continue;
                    ret = backtrackEvaluate(graph, key, targetNode,
                            accProduct * neighbours[key], visited);

                    if (ret != -1.0)
                        break;

                }
            }
            
            // unmark the visit, for the next backtracking
            visited.Remove(currNode);
            return ret;
        }
    }
}

