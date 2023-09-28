



public class Program
{
    public static void Main()
    {
        int[] arr = new int[] { 100, 0, 99, 3, -1, 3 };
        Trainee[] Ts = new Trainee[]
        {
            new Trainee { Id=1, Name="Hany"},
            new Trainee { Id=2, Name="Saja"},
            new Trainee { Id=4, Name="Osaman"},
        };

        Trainee[] result =
             QueryMethods.WhereMethod(Ts, t => t.Id > 1);

        SuperList<Trainee> sL = new SuperList<Trainee>()
        {
            new Trainee{Id=1, Name="Samaa"},
            new Trainee{Id=3, Name="Ahmed"},
        };


        foreach (Trainee trainee in result)
            Console.WriteLine($"ID:{trainee.Id}, Name: {trainee.Name}");



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