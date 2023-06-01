using System;
using System.Collections;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

    public class QueueOnStacks<T>
    {
        private readonly Stack<T> s1;
        private readonly Stack<T> s2;

        public QueueOnStacks()
        {
            s1 = new Stack<T>();
            s2 = new Stack<T>();
        } 

        public void Enqueue(T item)
        {
            while (s1.Count > 0)
            {
                s2.Push(s1.Pop());
            }
            
            s1.Push(item);
          
            while (s2.Count > 0)
            {
                s1.Push(s2.Pop());
            }
        }

        public T Dequeue()
        {
            if (s1.Count > 0)
            {
                return s1.Pop();
            }

            return default(T);
        }
        
        public int Size()
        {
            return s1.Count;
        }
        
    }
}