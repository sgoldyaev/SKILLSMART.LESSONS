using System;

namespace AlgorithmsDataStructures;

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
                index ++;
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

            if (index > 0 && except[index-1].Equals(left))
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
                index ++;
                candidate = default(T);
            }
        }

        while (index1 < sorted1.Length)
            except[index++] = sorted1[index1++];

        Array.Resize(ref except, index);

        return except;
    }

}
