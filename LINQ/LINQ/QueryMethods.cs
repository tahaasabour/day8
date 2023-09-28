

public class QueryMethods
{
    public static T First<T>(T[] items)
    {
        return items[0];
    }
    public static T Last<T>(T[] items)
    {
        return items[items.Length - 1];
    }
    public static T[] WhereMethod<T>(T[] items, Func<T, bool> filter)
    {
        T[] arr = new T[items.Length];
        int count = 0;
        for (int i = 0; i < items.Length; i++)
        {
            if (filter(items[i]))
                arr[count++] = items[i];
        }
        Array.Resize(ref arr, count);
        return arr;
    }
}