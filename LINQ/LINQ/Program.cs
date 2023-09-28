



public class Program
{


    
    
    


    public static void Main()
    {
        int[] arr = new int[] { 100, 0, 99, 3, -1, 3 };

        Console.WriteLine($"First Element: {QueryMethods.First<int>(arr)}");
        Console.WriteLine($"Last Element: {QueryMethods.Last(arr)}");

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();


        int[] evens = QueryMethods.WhereMethod<int>(arr, i => i %2 ==0);
        
        foreach(int i in evens)
            Console.WriteLine(i);


    }
}