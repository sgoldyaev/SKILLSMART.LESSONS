using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

    public class CircleBuffer<T>
    {
        private readonly long length;
        private readonly Queue<T> list;

        public CircleBuffer(long length)
        {
            this.length = length;
            
            list = new Queue<T>();
        } 

        public void Enqueue(T item)
        {
            if (list.Size() == length)
            {
                list.Dequeue();
            }
            
            list.Enqueue(item);
        }

        public T Dequeue()
        {
            return list.Dequeue();
        }
        
        public int Size() 
        {
            return list.Size();
        }
        
    }
}