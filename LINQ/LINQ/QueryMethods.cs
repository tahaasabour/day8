
using System;
using System.Collections.Generic;
public class QueryMethods
{
    public static T First<T>(IEnumerable<T> items)
    {
        int i = 0; 
        foreach(T item in items)
        {
            if(i == 0)
                return item;
        }
        return default;
    }
    public static T Last<T>(T[] items)
    {
        return items[items.Length - 1];
    }
    public static IEnumerable<T> WhereMethod<T>(IEnumerable<T> items, Func<T, bool> filter)
    {
        foreach(T item in items)
        {
            if(filter(item))
                yield return item;
        }
    }
}