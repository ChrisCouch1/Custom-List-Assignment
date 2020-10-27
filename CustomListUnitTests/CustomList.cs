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
            items = new T[4];
        }

        public void Add(T items)
        {
            //1. I'll need to have an array.
            //2. I'll need to add the next item to the next open slot
            //3. If the array is full, I will need to create another array with twice the capacity,
            //   and copy the items from the old one to the new one.

            
        }
        public void Remove(T item)
        {
            //1. I'll need to search the array to find the correct item.
            //2. I'll need to remove that specific item.
            //3. I'll need the other object in the list to fill in the blank in proper order.

        }
    }
}
