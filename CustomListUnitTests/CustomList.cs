using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    
        public int Count { get; set; }
        
        public int Capacity { get; set; }
        
        private T[] items;

        public CustomList()
        {
            Count = 0;
            Capacity = 4;
            items = new T[Capacity];
        }

        public void Add(T item)
        {
            //*1. I'll need to have an array.
            //*2. I'll need to add the next item to the next open slot
            //-- have a function to check how many items exist, and set the indexer to +1.
            //3. If the array is full, I will need to create another array with twice the capacity,
            //   and copy the items from the old one to the new one.
            //-- run a foreach loop to find each item, copy it and set it in the new array.

            if (Count != Capacity)
            {
                items[Count] = item;
                Count++;
            }
            else if(Count == Capacity)
            {
                
                T[] itemsNew = new T[Capacity * 2];
                for(int i = 0; i < Count; i++)
                {                    
                    itemsNew[i]=items[i];
                    Count++;
                }
                items = itemsNew;
            }

            
        }
        public void Remove(T item)
        {
            //1. I'll need to search the array to find the correct item.
            //2. I'll need to remove that specific item.
            //3. I'll need the other object in the list to fill in the blank in proper order.
            //--That means making a loop to create a new array that is one element smaller,
            //--adding back all the original elements except for the one the user wants 
            //--to delete.
            T[] itemsNew = new T[Count - 1];

            foreach(T element in items)
            {
                if(element == item)
                {

                }

            }
            
        }
    }
}
