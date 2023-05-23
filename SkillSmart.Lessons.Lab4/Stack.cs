using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

    public class Stack<T>
    {
        private readonly List<T> list;
        
        public Stack()
        {
            list = new List<T>();
        } 

        public int Size() 
        {
            return list.Count;
        }

        public T Pop()
        {
            var result = default(T);
            
            if (list.Count > 0)
            {
                var last = list.Count - 1;
                result = list[last];
                list.RemoveAt(last);
            }
            
            return result;
        }
	  
        public void Push(T val)
        {
            // ваш код
            list.Add(val);
        }

        public T Peek()
        {
            var result = default(T);
            
            if (list.Count > 0)
                result = list[list.Count - 1];
            
            return result;
        }
    }
    
}