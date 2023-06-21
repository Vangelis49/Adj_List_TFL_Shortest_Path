//an undirected weighted graph.
//the graph consists of stations and the connections between them
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UndirectedWeightedGraph.Enum;

namespace UndirectedWeightedGraph
{
    internal class Graph
    {
        //A custom list (MyList<Station>) that stores the Station objects in the graph
        private MyList<Station> _stations = new MyList<Station>();
        public MyList<Station> stations { get { return _stations; } set { _stations = value; } }

        //This method creates a new Station object with the given name, access, and status,
        //adds it to the stations list, and returns the created station
        public Station CreateStation(string name, StationAccess stationAccess, bool status)
        {
            Station newStation = new Station(name, stationAccess, status);
            stations.Add(newStation);
            return newStation;
        }

        public MyList<MyLinkedList> CreateAdjList()
        {
            MyList<MyLinkedList> adjList = new MyList<MyLinkedList>();
            for (int i = 0; i < stations.Count(); i++)
            {
                adjList.Add(new MyLinkedList());
                Station st1 = stations[i];
                for (int j = 0; j < stations.Count(); j++)
                {
                    Station st2 = stations[j];
                    for (int k = 0; k < st1.edges.Count(); k++)
                    {
                        if (st1.edges[k].child == st2)
                        {
                            adjList[i].InsertAtTail(st1.edges[k]);
                        }
                    }
                }
            }
            return adjList;
        }

        //case 1

        public Station GetStationByName(string stationName)
        {
            for (int i = 0; i < stations.Count(); i++)
            {
                if (stations[i].name == stationName)
                {
                    return stations[i];
                }
            }
            return null;
        }

        public void UpdateWalkingTimeDelay(string fromStation, string toStation, int delay)
        {
            Station from = GetStationByName(fromStation);
            Station to = GetStationByName(toStation);

            if (from != null && to != null)
            {
                for (int i = 0; i < from.edges.Count(); i++)
                {
                    if (from.edges[i].child == to)
                    {
                        from.edges[i].weight += delay;
                        Console.WriteLine($"Updated delay for {fromStation} to {toStation}: {from.edges[i].weight} minutes");
                        break;
                    }
                }

                for (int i = 0; i < to.edges.Count(); i++)
                {
                    if (to.edges[i].child == from)
                    {
                        to.edges[i].weight += delay;
                        Console.WriteLine($"Updated delay for {toStation} to {fromStation}: {to.edges[i].weight} minutes");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("One or both of the stations were not found.");
            }
        }

        public void AddRemoveDelays()
        {
            Console.WriteLine("Enter the starting station:");
            string fromStation = Console.ReadLine();

            Console.WriteLine("Enter the ending station:");
            string toStation = Console.ReadLine();

            Console.WriteLine("Enter the delay in minutes (use a negative value to remove delay):");
            int delay = int.Parse(Console.ReadLine());

            Station startStation = GetStationByName(fromStation);

            if (startStation != null)
            {
                // Update the delay of the starting station
                //had to change for work the dijcstra
               //remember this// startStation.delay += delay;

                // If there's a negative delay, keep it non-negative (0)
                if (startStation.delay < 0 )
                {
                    startStation.delay = 0;
                }

                Console.WriteLine("Delay added/removed successfully.");
            }
            else
            {
                Console.WriteLine("Starting station not found.");
            }

            UpdateWalkingTimeDelay(fromStation, toStation, delay);
        }


        public int GetWalkingTime(Station fromStation, Station toStation)
        {
            for (int i = 0; i < fromStation.edges.Count(); i++)
            {
                if (fromStation.edges[i].child == toStation)
                {
                    return fromStation.edges[i].weight;
                }
            }
            return int.MaxValue;
        }

        //case 2:

        public void MarkRoutePossibleOrImpossible(string fromStationName, string toStationName, bool isPossible)
        {
            Station fromStation = GetStationByName(fromStationName);
            Station toStation = GetStationByName(toStationName);

            if (fromStation != null && toStation != null)
            {
                Edge edge = fromStation.edges.FirstOrDefault(e => e.child == toStation);
                if (edge != null)
                {
                    edge.isPossible = isPossible;
                    Console.WriteLine($"Route from {fromStation.name} to {toStation.name} marked as {(isPossible ? "possible" : "impossible")}");
                }
                else
                {
                    Console.WriteLine("Edge not found.");
                }

                // Update the reverse edge (from toStation to fromStation) as well
                Edge reverseEdge = toStation.edges.FirstOrDefault(e => e.child == fromStation);
                if (reverseEdge != null)
                {
                    reverseEdge.isPossible = isPossible;
                }
                else
                {
                    Console.WriteLine("Reverse edge not found.");
                }
            }
            else
            {
                Console.WriteLine("One or both stations not found.");
            }
 
        }

        //for case 3
        public void PrintImpossibleWalkingRoutes()
        {
            Console.WriteLine("Closed routes:");
            for (int i = 0; i < stations.Count(); i++)
            {
                Station station = stations[i];
                for (int j = 0; j < station.edges.Count(); j++)
                {
                    Edge edge = station.edges[j];
                    if (!edge.isPossible)
                    {
                        // Print the stations and the reason for the route being impossible
                        Console.WriteLine($"{station.GetLineName()}: {station.name} - {edge.child.name} : route closed");
                    }
                }
            }
        }

        //case 4:

        public void PrintDelayedWalkingRoutes(MyList<MyLinkedList> adj, MyList<MyLinkedList> adj_backup)
        {
            Console.WriteLine("Delayed Routes");

            for (int i = 0; i < adj.Count(); i++)
            {
                Station station1 = stations[i];
                for (int j = 0; j < adj[i].Count; j++)
                {
                    Edge currentEdge = adj[i].Get(j);
                    Edge currentBackupEdge = adj_backup[i].Get(j);

                    int adjIndex = adj[i].IndexOf(currentEdge.child.name);
                    int adjBackupIndex = adj_backup[i].IndexOf(currentBackupEdge.child.name);

                    int adjWeight = adjIndex != -1 ? adj[i].FindWeight(adjIndex) : -1;
                    int adjBackupWeight = adjBackupIndex != -1 ? adj_backup[i].FindWeight(adjBackupIndex) : -1;

                    if (adjIndex != -1 && adjBackupIndex != -1 && adjWeight != adjBackupWeight)
                    {
                        Station toStation = stations[adjIndex];
                        Console.WriteLine($"{station1.name} - {toStation.name} : {adjBackupWeight} now {adjWeight}");
                    }
                }
            }
        }

        public void DijkstraAlgorithm(Station source, Station target, Graph graph, MyList<MyLinkedList> adj)
        {
            //initialize arrays for storing distances,
            //previous stations,
            //unvisited stations,
            //and a copy of the original station names
            int length = graph.stations.Count();
            int[] distance = new int[length];
            string[] previous = new string[length];
            string[] unvisited = new string[length];
            // keep an original copy to find later at line 267 the j 
            string[] original = new string[length];
            //distance array initially has all values set to int.MaxValue (infinity) except the source station, which has a distance of 0
            //initialize arrays
            for (int i = 0; i < length; i++)
            {
                distance[i] = int.MaxValue;
                unvisited[i] = graph.stations[i].name;
                original[i] = graph.stations[i].name;
            }
            distance[graph.stations.Indexof(source)] = 0;
            Station current;

            //The algorithm repeatedly finds the unvisited station with the smallest distance from the source and marks it as the current station.
            //If the current station is the target station, the loop breaks, as the shortest path is found.
            //The current station is then removed from the list of unvisited stations
            while (unvisited.Length > 0)
            {
                // node with min dist from sourse
                int min = int.MaxValue;
                int i = -1; // min index
                for (int k = 0; k < length; k++)
                {
                    // need to check only the queue Q = unvisited
                    // visit only the UNVISITED vertex with the
                    // smallest distance from the start
                    if (unvisited.Contains(original[k]) && distance[k] <= min)
                    {
                        min = distance[k];
                        i = k;
                    }
                }
                current = graph.stations[i];
                // 
                if (current == target)
                {
                    break;
                }
                // remove current from Q
                unvisited = unvisited.Where(val => val != current.name).ToArray();
                //
                for (int l = 0; l < current.edges.Count(); l++)
                //foreach (Edge edge in current.edges)
                {

                    //for each neighbor v of current still in Q
                    //for the current examine its UNVISITED heighbours
                    if (unvisited.Contains(current.edges[l].child.name) && current.edges[l].isPossible)
                    {
                        //code before case 1:
                        //int j = adj[i].IndexOf(current.edges[l].child.name);
                        //int m = Array.IndexOf(original, current.edges[l].child.name);
                        //int alt = distance[i] + adj[i].FindWeight(j);
                        int j = adj[i].IndexOf(current.edges[l].child.name);
                        int m = Array.IndexOf(original, current.edges[l].child.name);
                        //int alt = distance[i] + adj[i].FindWeight(j) + current.edges[l].delay;
                        //->remember this//int alt = distance[i] + adj[i].FindWeight(j) + current.delay;
                        int alt = distance[i] + graph.GetWalkingTime(current, current.edges[l].child) + current.delay;


                        if (alt < distance[m])
                        {
                            distance[m] = alt;
                            previous[m] = current.name;
                        }
                    }
                }
            }

            MyList<string> route = new MyList<string>();

            // start from the target station and backtrack to the source station using the "previous" array
            string cur = target.name;
            while (cur != source.name)
            {
                route.Add(cur);
                int index = Array.IndexOf(original, cur);
                cur = previous[index];
            }
            route.Add(source.name);
            route.Reverse(); // reverse the list to get the route from source to target

            for (int i = 0; i < route.Count(); i++)
            {
                int index = Array.IndexOf(original, route[i]);
                Station currentStation = graph.stations[index];

                // If it's the first station, print the starting point
                if (i == 0)
                {
                    Console.WriteLine($"({i + 1}) Start:  {route[i]}");
                }
                else
                {
                    // Calculate the travel time between the current and previous stations
                    int travelTime = distance[index] - distance[Array.IndexOf(original, route[i - 1])];
                    Station previousStation = graph.stations[Array.IndexOf(original, route[i - 1])];

                    // If the current and previous stations are on different lines, print the change of line
                    if (currentStation.GetLineName() != previousStation.GetLineName())
                    {
                        //Console.WriteLine($"    Change: {previousStation.name} ({previousStation.GetLineName()}) to {currentStation.name}"); //({currentStation.GetLineName()})
                    }

                    // Print the travel from the previous station to the current station with the travel time
                    if (travelTime > 0)
                    {
                        Console.WriteLine($"({i + 1})         {previousStation.name} to {currentStation.name} {travelTime} min");
                    }
                    else
                    {
                        Console.WriteLine($"({i + 1}) Change: {previousStation.name} to {currentStation.name} {travelTime} min");
                    }
                }
            }

            // Print the ending point of the route
            Console.WriteLine($"({route.Count() + 1}) End:    {target.name}");

            // Print the total journey time
            Console.WriteLine($"Total Journey Time: {distance[Array.IndexOf(original, target.name)]} minutes \n");
        }

    }
}
