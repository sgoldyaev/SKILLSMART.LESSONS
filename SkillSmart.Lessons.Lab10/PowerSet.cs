using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{
    public static class ArrayMath
    {
        public static T[] Intersect<T>(T[] source, T[] destination) where T : IComparable<T>
        {
            var sorted1 = (T[])source.Clone();
            var sorted2 = (T[])destination.Clone();
            var intersect = new T[sorted1.Length + sorted2.Length];

            Array.Sort(sorted1);
            Array.Sort(sorted2);

            var index = 0;
            var index1 = 0;
            var index2 = 0;
            var left = default(T);
            var right = default(T);

            while (index1 < sorted1.Length && index2 < sorted2.Length)
            {
                if (index1 < sorted1.Length) left = sorted1[index1];
                if (index2 < sorted2.Length) right = sorted2[index2];

                if (left == null)
                {
                    index1++;
                    continue;
                }
                if (right == null)
                {
                    index2++;
                    continue;
                }

                var compare = left.CompareTo(right);
                if (compare == 0)
                {
                    intersect[index] = left;
                    index1++;
                    index2++;
                    index++;
                }
                if (compare < 0) index1++;
                if (compare > 0) index2++;
            }

            Array.Resize(ref intersect, index);

            return intersect;
        }

        public static T[] Union<T>(T[] source, T[] destination) where T : IComparable<T>
        {
            var sorted1 = (T[])source.Clone();
            var sorted2 = (T[])destination.Clone();
            var union = new T[sorted1.Length + sorted2.Length];

            Array.Sort(sorted1);
            Array.Sort(sorted2);

            var index = 0;
            var index1 = 0;
            var index2 = 0;
            var left = default(T);
            var right = default(T);
            var candidate = default(T);

            while (index1 < sorted1.Length && index2 < sorted2.Length)
            {
                if (index1 < sorted1.Length) left = sorted1[index1];
                if (index2 < sorted2.Length) right = sorted2[index2];

                if (left == null)
                {
                    index1++;
                    continue;
                }
                if (right == null)
                {
                    index2++;
                    continue;
                }

                var compare = left.CompareTo(right);
                if (compare < 0)
                {
                    candidate = left;
                    index1++;
                }
                else if (compare > 0)
                {
                    candidate = right;
                    index2++;
                }
                else
                {
                    candidate = left;
                    index1++;
                }

                if (candidate != null && (index == 0 || !union[index - 1].Equals(candidate)))
                {
                    union[index] = candidate;
                    index++;
                    candidate = default(T);
                }
            }

            while (index1 < sorted1.Length)
                union[index++] = sorted1[index1++];

            while (index2 < sorted2.Length)
                union[index++] = sorted2[index2++];


            Array.Resize(ref union, index);

            return union;
        }

        public static T[] Except<T>(T[] source, T[] destination) where T : IComparable<T>
        {
            var sorted1 = (T[])source.Clone();
            var sorted2 = (T[])destination.Clone();
            var except = new T[sorted1.Length + sorted2.Length];

            Array.Sort(sorted1);
            Array.Sort(sorted2);

            var index = 0;
            var index1 = 0;
            var index2 = 0;
            var left = default(T);
            var right = default(T);
            var candidate = default(T);

            while (index1 < sorted1.Length && index2 < sorted2.Length)
            {
                if (index1 < sorted1.Length) left = sorted1[index1];
                if (index2 < sorted2.Length) right = sorted2[index2];

                if (left == null)
                {
                    index1++;
                    continue;
                }
                if (right == null)
                {
                    index2++;
                    continue;
                }

                if (index > 0 && except[index - 1].Equals(left))
                {
                    index1++;
                    continue;
                }

                var compare = left.CompareTo(right);
                if (compare < 0)
                {
                    candidate = left;
                    index1++;
                }
                else if (compare > 0)
                {
                    index2++;
                }
                else
                {
                    index1++;
                    index2++;
                }

                if (candidate != null && (index == 0 || !except[index - 1].Equals(candidate)))
                {
                    except[index] = candidate;
                    index++;
                    candidate = default(T);
                }
            }

            while (index1 < sorted1.Length)
                except[index++] = sorted1[index1++];

            Array.Resize(ref except, index);

            return except;
        }

    }

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

    // наследуйте этот класс от HashTable
    // или расширьте его методами из HashTable
    public class PowerSet<T> : HashTable<T>
        where T : IComparable<T>
    {
        private int count = 0;

        public PowerSet()
            : base(20_000, 29)
        {
            // ваша реализация хранилища
        }

        public int Size()
        {
            // количество элементов в множестве
            return count;
        }

        public bool Get(T value)
        {
            // возвращает true если value имеется в множестве,
            // иначе false
            return base.Find(value) > -1;
        }

        public override int Put(T value)
        {
            // всегда срабатывает
            if (value == null) return -1;

            var slotIndex = Find(value);

            if (slotIndex > -1) 
                return slotIndex;
            
            else if (slotIndex == -1)
                slotIndex = SeekSlot(value);

            if (slotIndex > -1)
            {
                slots[slotIndex] = value;
                count ++;
            }
            return slotIndex;
        }

        public bool Remove(T value)
        {
            // возвращает true если value удалено
            // иначе false
            var slot = base.Find(value);

            if (slot == -1) return false;
            else
            {
                base.slots[slot] = default(T);
                count --;
                return true;
            }
        }

        public PowerSet<T> Intersection(PowerSet<T> set2)
        {
            // пересечение текущего множества и set2
            var result = new PowerSet<T>();

            if (Size() == 0 && set2.Size() == 0) return result;

            //foreach (var item in slots.Where(x => x != null).Intersect(set2.slots.Where(x => x != null)).Where(x => x != null).ToArray()) 
            foreach (var item in ArrayMath.Intersect<T>(slots, set2.slots)) 
                result.Put(item);
            
            return result;
        }

        public PowerSet<T> Union(PowerSet<T> set2)
        {
            // объединение текущего множества и set2
            var result = new PowerSet<T>();

            if (Size() == 0 && set2.Size() == 0) return result;

            //foreach (var item in slots.Where(x => x != null).Union(set2.slots.Where(x => x != null)).Where(x => x != null).ToArray()) 
            foreach (var item in ArrayMath.Union<T>(slots, set2.slots)) 
                result.Put(item);
            
            return result;
        }

        public PowerSet<T> Difference(PowerSet<T> set2)
        {
            // разница текущего множества и set2
            var result = new PowerSet<T>();

            if (Size() == 0 && set2.Size() == 0) return result;

            //foreach (var item in slots.Where(x => x != null).Except(set2.slots.Where(x => x != null)).Where(x => x != null).ToArray()) 
            foreach (var item in ArrayMath.Except<T>(slots, set2.slots)) 
                result.Put(item);
            
            return result;
        }

        public bool IsSubset(PowerSet<T> set2)
        {
            // возвращает true, если set2 есть
            // подмножество текущего множества,
            // иначе false

            if (set2.Size() == 0) return true;
            else if (Size() == 0) return false;

            var set = ArrayMath.Except<T>(set2.slots, slots);
            
            return set.Length == 0;
        }
    }
}