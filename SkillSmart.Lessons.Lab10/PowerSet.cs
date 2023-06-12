using System;
using System.Collections;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

    // наследуйте этот класс от HashTable
    // или расширьте его методами из HashTable
    public class PowerSet<T> : HashTable<T>
    {
        private int count = 0;

        public PowerSet() 
            : base(20_000, 17)
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
            var find = base.Find(value);

            if (find > -1) return find;

            var put = base.Put(value);

            if (put > -1) count ++;

            return put;
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
            return null;
        }

        public PowerSet<T> Union(PowerSet<T> set2)
        {
            // объединение текущего множества и set2
            return null;
        }

        public PowerSet<T> Difference(PowerSet<T> set2)
        {
            // разница текущего множества и set2
            return null;
        }

        public bool IsSubset(PowerSet<T> set2)
        {
            // возвращает true, если set2 есть
            // подмножество текущего множества,
            // иначе false
            return false;
        }
    }
}
