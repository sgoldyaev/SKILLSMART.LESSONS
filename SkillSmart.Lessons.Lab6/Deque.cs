using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

    public class Deque<T>
    {
        private readonly List<T> list;
        
        public Deque()
        {
            list = new List<T>();
        }

        public void AddFront(T item)
        {
            list.Insert(0, item);
        }

        public void AddTail(T item)
        {
            list.Add(item);
        }

        public T RemoveFront()
        {
            if (list.Count > 0)
            {
                var item = list[0];
                list.RemoveAt(0);
                return item;
            }
            
            return default(T);
        }

        public T RemoveTail()
        {
            if (list.Count > 0)
            {
                var item = list[list.Count - 1];
                list.RemoveAt(list.Count - 1);
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
