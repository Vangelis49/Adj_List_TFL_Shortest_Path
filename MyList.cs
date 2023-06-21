//This code defines a custom generic list class called MyList<T>
//It provides an implementation of a simple dynamic array for storing objects of type T
//This custom list implementation was used instead of the built-in List<T> class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndirectedWeightedGraph
{
    internal class MyList<T>
    {
        //count: An integer that stores the number of elements in the list
        //items: An array of type T that stores the actual elements in the list
        //this[int index]: An indexer that allows getting and setting the value of the list at the specified index
        private int _count;
        public int count { get { return _count; } set { _count = value; } }
        private T[] items;
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException();
                }
                return items[index];
            }
            set
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException();
                }
                items[index] = value;
            }
        }
        //DEFAULT_CAPACITY: A constant integer that defines the default capacity of the list (in this case, 4)
        private const int DEFAULT_CAPACITY = 4;

        //The constructor MyList() initializes the items array with the default capacity and sets the count to 0
        public MyList()
        {
            this.items = new T[DEFAULT_CAPACITY];
            this.count = 0;
        }

        //Returns the current number of elements in the list
        public int Count()
        {
            return count;
        }

        //Adds an item to the list. If the list is full,
        //it resizes the underlying array to double its capacity before adding the item
        public void Add(T item)
        {
            if (count == items.Length)
            {
                T[] newItems = new T[items.Length * 2];
                for (int i = 0; i < count; i++)
                {
                    newItems[i] = items[i];
                }
                items = newItems;
            }
            items[count++] = item;
        }

        //Searches for the specified item in the list and returns its index if found; otherwise, returns -1
        public int Indexof(T target)
        {
            for (int i = 0; i < count; i++)
            {
                if (Equals(items[i], target))
                {
                    return i;
                }

            }
            return -1;
        }

        //Reverses the order of elements in the list
        public void Reverse()
        {
            int leftIndex = 0;
            int rightIndex = count - 1;
            while (leftIndex < rightIndex)
            {
                T temp = items[leftIndex];
                items[leftIndex] = items[rightIndex];
                items[rightIndex] = temp;
                leftIndex++;
                rightIndex--;
            }
        }

        //Checks if there is an element in the list that satisfies the specified predicate
        //(a function that takes an element of type T and returns a boolean).
        //Returns true if such an element exists, otherwise returns false
        public bool Exists(Func<T, bool> predicate)
        {
            for (int i = 0; i < count; i++)
            {
                if (predicate(items[i]))
                {
                    return true;
                }
            }
            return false;
        }

        //for case 2:
        public T FirstOrDefault(Func<T, bool> predicate)
        {
            for (int i = 0; i < Count(); i++)
            {
                if (predicate(this[i]))
                {
                    return this[i];
                }
            }

            return default(T);
        }

        //??
        public int IndexOf(T item)
        {
            for (int i = 0; i < Count(); i++)
            {
                if (EqualityComparer<T>.Default.Equals(this[i], item))
                {
                    return i;
                }
            }

            return -1;
        }

        
    }
}
