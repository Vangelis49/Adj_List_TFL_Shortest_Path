using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndirectedWeightedGraph
{
    internal class MyLinkedList
    {
        //A MyLListNode object representing the first node in the linked list
        private MyLListNode head;
        //A MyLListNode object representing the last node in the linked lis
        private MyLListNode tail;
        //An int representing the number of elements in the linked list
        private int count;

        //takes an Edge object as a parameter and inserts it at the end of the linked list
        //If the list is empty, it sets both the head and tail to the new item
        //If the list is not empty, it sets the current tail's next reference to the new item and updates the tail to be the new item
        //count is incremented after adding the new item
        public void InsertAtTail(Edge edge)
        {
            MyLListNode newItem = new MyLListNode(edge);
            if (tail == null)
            {
                head = newItem;
                tail = newItem;
            }
            else
            {
                tail.next = newItem;
                tail = newItem;
            }
            count++;
        }

        //This method takes a string value as a parameter and returns the index of the first occurrence of a node with that name in the linked list
        //If the value is not found, it returns -1
        //The method iterates through the linked list, comparing the current node's name with the input value,
        //and increments an index counter until the value is found or the end of the list is reached
        public int IndexOf(string value)
        {
            MyLListNode current = head;
            int index = 0;

            while (current != null)
            {
                if (current.name.Equals(value))
                {
                    return index;
                }

                current = current.next;
                index++;
            }

            return -1;
        }

        //takes an int n as a parameter, representing the index of the node in the list,
        //and returns the weight of the edge associated with that node.
        //It iterates through the list until it reaches the node at the given index,
        //and then returns the weight of the edge associated with that node
        public int FindWeight(int n)
        {
            MyLListNode current = head;
            int weight = current.weight;
            for (int i = 0; i < n; i++)
            {
                current = current.next;
                weight = current.weight;
            }
            return weight;
        }

        //for case 4:
        public int Count
        {
            get { return count; }
        }


        public Edge Get(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new ArgumentOutOfRangeException("Index is out of range.");
            }

            MyLListNode current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.next;
            }

            return new Edge(current.station, current.weight); // Use the stored Station object
        }

    }
}
