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
        //make sure to address accessing index outside of the size of array
        public T this[int i]
        {
            get
            {
                if (i <= items.Length)
                {
                return items[i];
                }
                else
                {
                throw new IndexOutOfRangeException();
                }
            }
            set
            {
                items[i] = value;
            }
        }


        //Constructor
        public CustomList()
        {
            capacity = 4;
            items = new T[capacity];
        }

        public void Add(T item)
        {
            if (count >= capacity)
            {
                capacity *= 2;
                T[] temporary = items;
                items = new T[capacity];
                for (int i = 0; i < temporary.Length; i++)
                {
                    items[i] = temporary[i];
                }
            }
            items[count] = item;
            count++;
        }

        public void Remove(T item)
        {
            T[] temporary = new T[items.Length];
            int j = 0;
            int removedCount = 0;
            for (int i = 0; i < items.Length; i++)
            {
                if(!items[i].Equals(item) || removedCount == 1)
                {
                    temporary[j] = items[i];
                    j++;
                }
                else
                {
                    count--;
                    removedCount++;
                }
            }
            items = temporary;
        }

        //public override string ToString()
        //{
        //    return base.ToString();
        //}
    }
}

//array loops if statements only
//indexer??
//ToString
