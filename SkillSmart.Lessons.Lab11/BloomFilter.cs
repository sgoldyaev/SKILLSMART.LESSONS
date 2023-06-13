using System.Collections.Generic;
using System;
using System.IO;

namespace AlgorithmsDataStructures
{
    public class BloomFilter
    {
        private int bitMask = 0;
        public int filter_len;

        public BloomFilter(int f_len)
        {
            filter_len = f_len;
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
                result %= sizeof(int) * 8;
            }
            // реализация ...
            return (int)result;
        }

        public int Hash2(string str1)
        {
            // 223
            long result = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                result *= 223;
                result += (int)str1[i];
                result %= sizeof(int) * 8;
            }
            // реализация ...
            return (int)result;
        }

        public void Add(string str1)
        {
            // добавляем строку str1 в фильтр
            bitMask |= Hash1(str1);
            bitMask |= Hash2(str1);
        }

        public bool IsValue(string str1)
        {
            // проверка, имеется ли строка str1 в фильтре
            var mask1 = bitMask & Hash1(str1);
            var mask2 = bitMask & Hash2(str1);

            return (mask1 | mask2) == 1;
        }
    }
}