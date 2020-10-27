using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList_Proj
{
    public class CustomList<T>
    {
        private int count;
        private int capacity;
        public T this[int i]
        {
            get { return items[i]; }
            set { items[i] = value; }
        }
    
        public int Count
        {
            get
            {
                return count;
            }
        }
        public int Capacity
        {
            get
            {
                return capacity;
            }
        }
        private T[] items;

        public CustomList()
        {
            count = 0;
            capacity = 4;
            items = new T[capacity];
        }

        public void Add(T item)
        {
            //1. I'll need to have an array.
            //2. I'll need to add the next item to the next open slot
            //-- have a function to check how many items exist, and set the indexer to +1.
            //3. If the array is full, I will need to create another array with twice the capacity,
            //   and copy the items from the old one to the new one.
            //-- run a foreach loop to find each item, copy it and set it in the new array.

            if (count != capacity)
            {
                items[count] = item;
                count++;
            }
            else if(count == capacity)
            {

            }

            
        }
        public void Remove(T item)
        {
            //1. I'll need to search the array to find the correct item.
            //2. I'll need to remove that specific item.
            //3. I'll need the other object in the list to fill in the blank in proper order.

        }
    }
}
