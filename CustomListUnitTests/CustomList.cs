using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList_Proj
{
    public class CustomList<T> : IEnumerable
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

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }


        public CustomList()
        {
            capacity = 4;
            items = new T[capacity];
        }

        public void Add(T item)
        {
            //*1. I'll need to have an array.
            //*2. I'll need to add the next item to the next open slot
            //-- have a function to check how many items exist, and set the indexer to +1.
            //3. If the array is full, I will need to create another array with twice the capacity,
            //   and copy the items from the old one to the new one.
            //-- run a foreach loop to find each item, copy it and set it in the new array.

            if (count == capacity)
            {
                capacity *= 2;
                T[] itemsNew = new T[capacity];

                for (int i = 0; i < count; i++)
                {
                    itemsNew[i] = items[i];
                }
                items = itemsNew;
            }
            items[count] = item;
            count++;


        }
        public void Remove(T item)
        {
            //1. I'll need to search the array to find the correct item.
            //2. I'll need to remove that specific item.
            //3. I'll need the other object in the list to fill in the blank in proper order.
            //--That means making a loop to create a new array that is one element smaller,
            //--adding back all the original elements except for the one the user wants 
            //--to delete.
            T[] itemsNew = new T[capacity];
            count = 0;

            foreach (T element in items)
            {
                if (element.Equals(item))
                {
                    item = default(T);
                }
                else
                {
                    itemsNew[count] = element;
                    count++;
                }
                items = itemsNew;
            }
        }
        public override string ToString()
        {
            string displayList ="";
            int i;
            if (count > 0)
            {
                for (i = 0; i < count; i++)
                {
                    displayList += items[i].ToString() + ", ";
                }
                displayList = displayList.Substring(0, displayList.Length - 2);
            }
            return displayList;
        }

        public static CustomList<T> operator+ (CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> outputList = new CustomList<T>();
            foreach(T item in list1)
            {
                outputList.Add(item);
            }
            foreach(T item in list2)
            {
                outputList.Add(item);
            }

            return outputList;

        }

        public static CustomList<T> operator- (CustomList <T> list1, CustomList<T> list2)
        {
            
            for (int i = 0; i < list1.count; i++)
            {
                for (int j = 0; j < list2.count; j++)
                {
                    if (list1[i].Equals(list2[j]))
                    {
                        list1.Remove(list1[i]);
                    }                         
                  
                }
            }
            return list1;
        }      
    }
}
