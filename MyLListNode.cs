using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndirectedWeightedGraph
{
    internal class MyLListNode
    {

        //private field _weight with a public property weight that holds the weight of the edge
        private int _weight;
        public int weight { get { return _weight; } set { _weight = value; } }
        //private field _name with a public property name that holds the name of the connected child station
        private string _name;
        public string name { get { return _name; } set { _name = value; } }
        //private field _next with a public property next that holds a reference to the next node in the linked list
        private MyLListNode _next;
        public MyLListNode next { get { return _next; } set { _next = value; } }


        //for case 4
        private Station _station;
        public Station station { get { return _station; } set { _station = value; } }




        //The constructor of this class takes an Edge object as an input and
        //initializes the weight and name properties based on the edge's weight
        //and the child station's name, respectively
        //The next property is initialized to null, indicating the end of the list until a new node is added
        public MyLListNode(Edge edge)
        {
            weight = edge.weight;
            name = edge.child.name;
            next = null;

            //FOR CASE 4
            station = edge.child;
        }

       

    }
}
