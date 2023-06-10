using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

    public class HashTable
    {
        public int size;
        public int step;
        public string[] slots;

        public HashTable(int sz, int stp)
        {
            size = sz;
            step = stp;
            slots = new string[size];
            for (int i = 0; i < size; i++) slots[i] = null;
        }

        public int HashFun(string value)
        {
            if (value == null) return -1;

            // всегда возвращает корректный индекс слота
            return Math.Abs(value.GetHashCode() % size);
        }

        public int SeekSlot(string value)
        {
            // находит индекс пустого слота для значения, или -1
            return Search(value, x => x == null);
        }

        public int Put(string value)
        {
            // записываем значение по хэш-функции

            // возвращается индекс слота или -1
            // если из-за коллизий элемент не удаётся разместить
            var slotIndex = Find(value);
            if (slotIndex > -1)
                slots[slotIndex] = value;

            return slotIndex;
        }

        public int Find(string value)
        {
            // находит индекс слота со значением, или -1
             return Search(value, x => x == null || x == value);
       }

        private int Search(string value, Func<string, bool> filter)
        {
            var slotIndex = HashFun(value);
            if (slotIndex < 0) return slotIndex;
            if (filter(slots[slotIndex])) return slotIndex;

            for (var startIndex = 0; startIndex < size; startIndex++)
            {
                for (var index = 0; index < size; index+=step)
                {
                    var seekIndex = (slotIndex + index) % size;
                    var isTail = seekIndex == slotIndex - 1;
                    var isFound = filter(slots[seekIndex]);

                    if (isFound) return seekIndex;
                    if (isTail && !isFound) return -1;
                }
            }
            return -1;
        }
    }

}