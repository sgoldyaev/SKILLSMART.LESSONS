using System.Collections.Generic;
using System;
using System.IO;
using System.Diagnostics.Metrics;

namespace AlgorithmsDataStructures
{
    public class NativeCache<T>
    {
        public int count;
        public int size;
        public int step;
        public String[] slots;
        public T[] values;
        public int[] hits;

        public NativeCache(int sz = 10, int stp = 3)
        {
            size = sz;
            step = stp;
            count = 0;
            slots = new string[size];
            values = new T[size];
            hits = new int[size];
        }

        public int HashFun(string key)
        {
            if (key == null) return -1;

            return Math.Abs(key.GetHashCode() % size);
        }

        public int SeekSlot(string key)
        {
            return Search(HashFun(key), x => x == null);
        }

        public int Put(string key, T value)
        {
            if (value == null) return -1;

            if (count == size)
            {
                var minimum = 0;
                
                for (var index = 0; index < size; index ++)
                    if (hits[minimum] > hits[index]) minimum = index;

                slots[minimum] = default;
                values[minimum] = default;
                hits[minimum] = 0;
                count --;
            }

            var slotIndex = Search(HashFun(key), x => x?.Equals(key) == true);

            if (slotIndex == -1)
                slotIndex = SeekSlot(key);

            if (slotIndex > -1)
            {
                /// NOTE [sg]: key-value storage
                slots[slotIndex] = key;
                values[slotIndex] = value;
                count ++;
            }
            return slotIndex;
        }

        public T Get(string key)
        {
            var slotIndex = Search(HashFun(key), x => x?.Equals(key) == true);
            if (slotIndex > -1)
            {
                /// NOTE [sg]: hits inc
                hits[slotIndex] ++;
                return values[slotIndex];
            }

            return default;
        }

        public bool Remove(string key)
        {
            var slotIndex = Search(HashFun(key), x => x?.Equals(key) == true);
            if (slotIndex > -1)
            {
                /// NOTE [sg]: clean data here
                hits[slotIndex] = 0;
                slots[slotIndex] = default;
                values[slotIndex] = default;
                count --;
                return true;
            }

            return false;
        }

        private int Search(int slotIndex, Func<string, bool> filter)
        {
            if (slotIndex == -1) return slotIndex;
            if (filter(slots[slotIndex])) return slotIndex;

            var seekStep = step;
            for (var startIndex = 0; startIndex < 1; startIndex++)
            {
                for (var index = 0; index < size; index += seekStep)
                {
                    var seekIndex = (slotIndex + startIndex + index) % size;
                    var isTail = startIndex + 1 == size && seekIndex == slotIndex - 1;
                    var isFound = filter(slots[seekIndex]);

                    if (isFound) return seekIndex;
                    if (isTail && !isFound) return -1;
                }
            }
            return -1;
        }
    }
}