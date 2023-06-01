using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

    public class Deque<T>
    {
        ///  NOTE [sg]: O(1) -> LinkedList
        private readonly LinkedList<T> list;
        
        public Deque()
        {
            list = new LinkedList<T>();
        }

        public void AddFront(T item)
        {
            var head = list.First;

            if (head == null)
            {
                this.list.AddFirst(item);
            }
            else
            {
                list.AddBefore(head, item);
            }
        }

        public void AddTail(T item)
        {
            var tail = list.Last;

            if (tail == null)
            {
                this.list.AddLast(item);
            }
            else
            {
                list.AddAfter(tail, item);
            }
        }

        public T RemoveFront()
        {
            if (list.Count > 0)
            {
                var head = list.First;

                list.RemoveFirst();
                
                return head.Value;
            }
            
            return default(T);
        }

        public T RemoveTail()
        {
            if (list.Count > 0)
            {
                var tail = list.Last;

                list.RemoveLast();
                
                return tail.Value;
            }
            
            return default(T);
        }
        
        public int Size()
        {
            return list.Count;
        }
    }

}
