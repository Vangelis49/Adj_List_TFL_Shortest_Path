using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndirectedWeightedGraph
{
    internal class Edge
    {
        //A Station object representing the parent station of the edge
        private Station _parent;
        public Station parent { get { return _parent; } set { _parent = value; } }

        //A Station object representing the child station of the edge.
        //Since this is an undirected graph, the terms parent and child are interchangeable here
        private Station _child;
        public Station child { get { return _child; } set { _child = value; } }

        //An int representing the weight of the edge,
        //which could represent distance, time, or any other metric you choose to use for your graph
        private int _weight;
        public int weight { get { return _weight; } set { _weight = value; } }

        //for case 2:
        public bool isPossible { get; set; }

        public Edge(Station child, int weight)
        {
            this.child = child;
            this.weight = weight;
            this.isPossible = true;
        }

    }
}
