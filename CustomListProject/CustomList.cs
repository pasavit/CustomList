using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T> //T = int
    {
        //Global Member Variables
        private int count;
        private int capacity;
        private int index;
        private T[] items;
        private int nextIndex = 0;

        //Properties

        //Count
        public int Count
        {
            get
            {
                return count;
            }
        }

        //Capacity
        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }

        //Indexer
        public T this[int i]
        {
            get
            {
                return items[i];
            }
            set
            {
                items[i] = value;
            }
        }


        //Constructor
        public CustomList()
        {
            Capacity = 4;
            items = new T[Capacity];
        }


        //Methods
        public void Add(T item)
        {
            //logic to "add" to my items array//what are the steps to add item? increase capacity?
            //1. add item to list at next available index
            //2. if nextIndex > Capacity, Capacity doubles
            items[nextIndex++] = item;
            if (nextIndex > Capacity)
            {
                Capacity *= 2;
            }

        }

        public void Remove(T item)
        {
            //1. 
        }
    }
}

//array loops if statements only
//indexer??
//ToString
