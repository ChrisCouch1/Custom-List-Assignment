using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListUnitTests
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
        T[] items;

        public void Add(T items)
        {
            //logic to add items to the array.
            
        }
    }
}
