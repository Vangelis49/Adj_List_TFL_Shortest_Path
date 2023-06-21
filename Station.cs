//This code defines a Station class that represents a station in the graph.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UndirectedWeightedGraph.Enum;

namespace UndirectedWeightedGraph
{
    internal class Station
    {
        //The name of the station as a string
        //An enum StationAccess that indicates the type of station access
        //isActive: A boolean value that indicates whether the station is active/open (true) or inactive/closed (false)
        //A MyList<Edge> (custom list implementation) that stores the edges (connections) between this station and other stations

        private string _name;
        public string name { get { return _name; } set { _name = value; } }
        private StationAccess _stationAccess;
        public StationAccess stationAccess { get { return _stationAccess; } set { _stationAccess = value; } }
        private bool _isActive;
        public bool isActive { get { return _isActive; } set { _isActive = value; } }
        private MyList<Edge> _edges = new MyList<Edge>();
        public MyList<Edge> edges { get { return _edges; } set { _edges = value; } }

        //added for case 1:
        public int delay { get; set; }

        //added for case 2:
        public MyList<Edge> Edges
        {
            get { return edges; }
        }

        //constructor that takes the station's name, stationAccess, and status (isActive) as parameters
        public Station(string name, StationAccess stationAccess, bool status)
        {
            this.name = name;
            this.stationAccess = stationAccess;
            this.isActive = status;
        }

        //new for case 2
        public void AddTwoWayEdge(Station station, int w, bool isPossible = true)
        {
            Edge edge1 = new Edge(station, w) { isPossible = isPossible };
            edges.Add(edge1);

            Edge edge2 = new Edge(this, w) { isPossible = isPossible };
            station.edges.Add(edge2);
        }


        //new addition case 3
        public string GetLineName()
        {
            int startParenthesis = name.IndexOf("(");
            int endParenthesis = name.IndexOf(")");

            if (startParenthesis != -1 && endParenthesis != -1)
            {
                return name.Substring(startParenthesis + 1, endParenthesis - startParenthesis - 1);
            }

            return "";
        }

        //why overriden?
        //returns a string representation of the Station object,
        //including its name, station access, and status (open or closed)
        public override string ToString()
        {
            string resp = isActive ? "Open" : "Closed";

            return $"Station Name: {name} \n" +
                $"Station Access: {stationAccess} \n" +
                $"Station Status: {resp}";
        }
    }
}
