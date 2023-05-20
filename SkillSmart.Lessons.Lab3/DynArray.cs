using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

    public class DynArray<T>
    {
        public const int defaultSize = 16;
        public T [] array;
        public int count;
        public int capacity;

        public DynArray()
        {
            count = 0;
            MakeArray(defaultSize);
        }

        public void MakeArray(int new_capacity)
        {
            if (count == 0)
                array = new T[new_capacity];
            
            if (capacity == new_capacity)
                return;
            
            Array.Resize(ref array, new_capacity);
            
            capacity = new_capacity;
        }

        public T GetItem(int index)
        {
            if (index < 0)
                throw new IndexOutOfRangeException($"Index {index} is negative");
            
            if (index > count)
                throw new IndexOutOfRangeException($"Index {index} out of elements");

            return array[index];
        }

        public void Append(T itm)
        {
            if (count == capacity)
                MakeArray(capacity * 2);

            array[count++] = itm;
        }

        public void Insert(T itm, int index)
        {
            if (count + 1 == capacity)
                MakeArray(capacity * 2);
        }

        public void Remove(int index)
        {
            Array.ConstrainedCopy(array, index + 1, array, index, count - index - 1);

            array[--count] = default(T);

            if (count * 3 < capacity * 2 - 1)
                MakeArray(Math.Max(defaultSize, count));
        }

    }
}