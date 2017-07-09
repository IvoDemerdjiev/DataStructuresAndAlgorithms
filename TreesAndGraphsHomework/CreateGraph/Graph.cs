namespace CreateGraph
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Graph
    {
        /// <summary>
        /// Represents a directed unweighted graph structure.
        /// </summary>
        public class Graph
        {
            // Contains the vertices of the graph
            private int[,] vertices;

            /// <summary>
            /// Constructs the graph.
            /// </summary>
            /// <param name="vertices">the vertices of the graph</param>
            public Graph(int[,] vertices)
            {
                this.vertices = vertices;
            }

            /// <summary>
            /// Adds new edge from i to j.
            /// </summary>
            /// <param name="i">the starting vertex</param>
            /// <param name="j">the ending vertex</param>
            public void AddEdge(int i, int j)
            {
                vertices[i, j] = 1;
            }

            /// <summary>
            /// Removes the edge from i to j if such exists.
            /// </summary>
            /// <param name="i">the starting vertex</param>
            /// <param name="j">the ending vertex</param>
            public void RemoveEdge(int i, int j)
            {
                vertices[i, j] = 0;
            }

            /// <summary>
            /// Checks whether there is an edge between vertex i and j.
            /// </summary>
            /// <param name="i">the starting vertex</param>
            /// <param name="j">the ending vertex</param>
            /// <returns>true if there is an edge between
            /// vertex i and vertex j</returns>
            public bool HasEdge(int i, int j)
            {
                return vertices[i, j] == 1;
            }

            /// <summary>
            /// Returns the successors of a given vertex.
            /// </summary>
            /// <param name="i">the vertex</param>
            /// <returns>list with all successors of the given vertex</returns>
            public IList<int> GetSuccessors(int i)
            {
                IList<int> successors = new List<int>();

                for (int j = 0; j < vertices.GetLength(1); j++)
                {
                    if (vertices[i, j] == 1)
                    {
                        successors.Add(j);
                    }
                }

                return successors;
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
