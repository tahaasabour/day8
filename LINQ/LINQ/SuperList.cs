

using System.Collections;
using System.Collections.Generic;

public class SuperList<T> : IEnumerable<T>
{
    T[] items;
    int count;
    public SuperList(int size = 2)
    {
        count = 0;
        items = new T[size];
    }
    public void Add(T item)
    {
        if (count == items.Length)
            Array.Resize(ref items, items.Length * 2);
        items[count++] = item;
    }
    public IEnumerator<T> GetEnumerator()
    {
        foreach (T item in items)
            yield return item;
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}