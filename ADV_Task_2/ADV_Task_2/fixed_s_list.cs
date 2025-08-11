using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV_Task_2
{
    //3.	implement a custom list called FixedSizeList<T> with a predetermined capacity. This list should not allow more elements than its capacity and should provide clear messages if one tries to exceed it or access invalid indices.
    internal class FixedSizeList<T>
    {
        private List<T> list;
        private readonly int Capacity;

        public FixedSizeList(int Capacity)
        {
            this.Capacity = Capacity;
            list = new List<T>(Capacity);
        }

        public void Add(T item)
        {
            if (Capacity > list.Count)
                list.Add(item);
            else
                Console.WriteLine("list is full");
        }

        public void Clear()
        { list.Clear(); }

        public T GetValue(int index)
        { 
            if(index<Capacity&&index>=0)
            return list[index];
        else 
               throw new IndexOutOfRangeException("ndexOutOfRange");
            
        }
    }
}