using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

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

            var set = set2.slots.Where(x => x != null).Except(slots.Where(x => x != null)).Where(x => x != null);
            
            return !set.Any();
        }
    }
}