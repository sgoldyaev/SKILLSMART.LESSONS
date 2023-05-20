namespace AlgorithmsDataStructures;

public static class DinArrayExtensions
{
    public static void From<T>(this DynArray<T> array, T[] source)
    {
        foreach (var item in source)
            array.Append(item);
    }
}
