using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

    public class Queue<T>
    {
        private readonly List<T> list;
        
        public Queue()
        {
            list = new List<T>();
        } 

        public void Enqueue(T item)
        {
            list.Add(item);
        }

        public T Dequeue()
        {
            if (list.Count > 0)
            {
                var item = list[0];
                list.RemoveAt(0);

                return item;
            }

            return default(T);
        }
        
        public int Size() 
        {
            return list.Count;
        }
        
    }
}