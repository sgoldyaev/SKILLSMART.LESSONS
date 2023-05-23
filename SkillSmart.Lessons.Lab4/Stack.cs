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
                result = list[0];
                list.RemoveAt(0);
            }
            
            return result;
        }
	  
        public void Push(T val)
        {
            // ваш код
            list.Insert(0, val);
        }

        public T Peek()
        {
            var result = default(T);
            
            if (list.Count > 0)
                result = list[0];
            
            return result;
        }
    }
    
}