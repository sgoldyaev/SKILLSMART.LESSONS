using System.Collections.Generic;
using System;
using System.IO;

namespace AlgorithmsDataStructures
{
    public class BloomFilter
    {
        private int filter;
        public int filter_len;

        public BloomFilter(int f_len)
        {
            filter_len = f_len;
            filter = 0;
            // создаём битовый массив длиной f_len ...

            // bitArray = new BitArray(new byte[filter_len / sizeof(byte)]);
        }

        // хэш-функции
        public int Hash1(string str1)
        {
            long result = 0;
            // 17
            for (int i = 0; i < str1.Length; i++)
            {
                result *= 17;
                result += (int)str1[i];
            }
            result %= filter_len;
            // реализация ...
            return Math.Abs((int)result);
        }

        public int Hash2(string str1)
        {
            // 223
            long result = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                result *= 223;
                result += (int)str1[i];
            }
            result %= filter_len;
            // реализация ...
            return Math.Abs((int)result);
        }

        public void Add(string str1)
        {
            // добавляем строку str1 в фильтр
            var hash1 = Hash1(str1);
            var hash2 = Hash2(str1);

            filter |= hash1 == 0 ? 0 : 1 << hash1;
            filter |= hash2 == 0 ? 0 : 1 << hash2;
        }

        public bool IsValue(string str1)
        {
            // проверка, имеется ли строка str1 в фильтре
            var hash1 = Hash1(str1);
            var hash2 = Hash2(str1);

            var mask1 = (hash1 == 0 ? 0 : 1 << hash1);
            var mask2 = (hash2 == 0 ? 0 : 1 << hash2);

            return (mask1 == (mask1 & filter)) && (mask2 == (mask2 & filter));
        }
    }
}