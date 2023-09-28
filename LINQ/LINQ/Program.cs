



using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        IEnumerable<int> arr = new int[] { 100, 0, 99, 3, -1, 3 };
        Trainee[] Ts = new Trainee[]
        {
            new Trainee { Id=1, Name="Hany"},
            new Trainee { Id=2, Name="Saja"},
            new Trainee { Id=4, Name="Osaman"},
        };

        IEnumerable<Trainee> result =
             QueryMethods.WhereMethod(Ts, t => t.Id > 1);

        SuperList<Trainee> sL = new SuperList<Trainee>()
        {
            new Trainee{Id=1, Name="Samaa"},
            new Trainee{Id=3, Name="Ahmed"},
            new Trainee{Id=100, Name="Mostafa"},
        };

        IEnumerable<Trainee> Ts2 =
             QueryMethods.WhereMethod(sL, t => t.Id > 3);
        foreach(Trainee t in Ts2) 
        {
            Console.WriteLine($"{t.Id},  {t.Name}");
        }

    }
}