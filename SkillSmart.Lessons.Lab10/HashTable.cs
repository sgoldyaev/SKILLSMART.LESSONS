using System.Diagnostics;

namespace AlgorithmsDataStructures
{

    public class HashTable<T>
    {
        public int size;
        public int step;
        public T[] slots;

        public HashTable(int sz, int stp)
        {
            size = sz;
            step = stp;
            slots = new T[size];
            for (int i = 0; i < size; i++) slots[i] = default(T);
        }

        public int HashFun(T value)
        {
            if (value == null) return -1;

            // всегда возвращает корректный индекс слота
            return Math.Abs(value.GetHashCode() % size);
        }

        public int SeekSlot(T value)
        {
            // находит индекс пустого слота для значения, или -1
            return Search(HashFun(value), x => x == null);
        }

        public virtual int Put(T value)
        {
            // записываем значение по хэш-функции
            if (value == null) return -1;

            // возвращается индекс слота или -1
            // если из-за коллизий элемент не удаётся разместить
            var slotIndex = Find(value);

            if (slotIndex == -1)
                slotIndex = SeekSlot(value);

            if (slotIndex > -1)
                slots[slotIndex] = value; 

            return slotIndex;
        }

        public int Find(T value)
        {
            // находит индекс слота со значением, или -1
             return Search(HashFun(value), x => x?.Equals(value) == true);
       }

        private int Search(int slotIndex, Func<T, bool> filter)
        {
            if (slotIndex == -1) return slotIndex;
            if (filter(slots[slotIndex])) return slotIndex;

            var seekStep = step;
            for (var startIndex = 0; startIndex < 1; startIndex++)
            {
                for (var index = 0; index < size; index+=seekStep)
                {
                    var seekIndex = (slotIndex + startIndex + index) % size;
                    var isTail = startIndex + 1 == size && seekIndex == slotIndex - 1;
                    var isFound = filter(slots[seekIndex]);

                    if (isFound) return seekIndex;
                    if (isTail && !isFound) return -1;
                }

                ///seekStep -= 2;
            }
            return -1;
        }
    }

}