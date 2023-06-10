using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

    public class NativeDictionary<T>
    {
        private readonly int step = 13;
        public int size;
        public string[] slots;
        public T[] values;

        public NativeDictionary(int sz)
        {
            size = sz;
            slots = new string[size];
            values = new T[size];
        }

        public bool IsKey(string key)
        {
            // возвращает true если ключ имеется,
            // иначе false
            return Find(key) > -1;
        }

        public void Put(string key, T value)
        {
            // гарантированно записываем 
            // значение value по ключу key
            var slot = Put(key);

            if (slot > -1) values[slot] = value;
        }

        public T Get(string key)
        {
            // возвращает value для key, 
            // или null если ключ не найден
            var slot = Find(key);

            if (slot > 0) return values[slot];

            return default(T);
        }
        
        public int HashFun(string value)
        {
            if (value == null) return -1;

            // всегда возвращает корректный индекс слота
            return Math.Abs(value.GetHashCode() % size);
        }

        private int SeekSlot(string value)
        {
            // находит индекс пустого слота для значения, или -1
            return Search(value, x => x == null);
        }

        private int Put(string value)
        {
            // записываем значение по хэш-функции

            // возвращается индекс слота или -1
            // если из-за коллизий элемент не удаётся разместить
            var slotIndex = Find(value);

            if (slotIndex == -1)
                slotIndex = SeekSlot(value);

            if (slotIndex > -1)
                slots[slotIndex] = value;

            return slotIndex;
        }

        private int Find(string value)
        {
            // находит индекс слота со значением, или -1
            return Search(value, x => x == value);
        }

        private int Search(string value, Func<string, bool> filter)
        {
            var slotIndex = HashFun(value);
            if (slotIndex < 0) return slotIndex;
            if (filter(slots[slotIndex])) return slotIndex;

            for (var startIndex = 0; startIndex < size; startIndex++)
            {
                for (var index = 0; index < size; index += step)
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