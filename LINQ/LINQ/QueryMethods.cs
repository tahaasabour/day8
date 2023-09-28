
using System;
using System.Collections.Generic;
public static class QueryMethods
{
    public static T First<T>(this IEnumerable<T> items)
    {
        int i = 0; 
        foreach(T item in items)
        {
            if(i == 0)
                return item;
        }
        return default;
    }
    public static T Last<T>(this T[] items)
    {
        return items[items.Length - 1];
    }
    public static IEnumerable<T> WhereMethod<T>(this IEnumerable<T> items, Func<T, bool> filter)
    {
        foreach(T item in items)
        {
            if(filter(item))
                yield return item;
        }
    }
    public static IEnumerable<T> TakeMethod<T>(this IEnumerable<T> items, int count)
    {
        int current = 0;
        foreach (T item in items)
        {
            current++;
            if (current <= count)
                yield return item;
        }
    }
    public static IEnumerable<TOut>  SelectMethod<T, TOut>(this IEnumerable<T> items,
                    Func<T, TOut> filter)
    {
        foreach (T item in items)
            yield return filter(item);
    }
}