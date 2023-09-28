



using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

public class Program
{
    public static void Main()
    {

        int[] arr = new int[] { 100, 5, 6, 7, 7, 8, 90 };
        var query = from nums in arr
                    where nums > 6
                    orderby nums descending
                    select nums;

        var query2 = arr.Where(i => i > 6).OrderByDescending(i => i);


        foreach(var item in query2 )
            Console.WriteLine(item);


        // Query Syntax 






        //foreach (int item in arr.OrderDescending().Skip(2).Take(2))
        //    Console.WriteLine(item);



        //Console.WriteLine(arr.FirstOrDefault()); ;
        //Console.WriteLine(arr.LastOrDefault()); ;

        //Console.WriteLine();
        //Console.WriteLine();
        //Console.WriteLine();
        //foreach (int item in arr.Where(i=> i > 6 ))
        //    Console.WriteLine(item);





        SuperList<Trainee> sL = new SuperList<Trainee>()
        {
            new Trainee{Id=10, Name="Samaa", Mobile ="3434343"},
            new Trainee{Id=3, Name="Ahmed", Mobile ="3434343"},
            new Trainee{Id=100, Name="Mostafa", Mobile ="3434343"},
            new Trainee{Id=9, Name="Galal", Mobile ="3434343"},
        };


        foreach (var t in sL.OrderBy(i => i.Id).Take(3).Select(i => new
        {
            Name = i.Name,
            ID = i.Id
        }))
            Console.WriteLine(t.ID + ", " + t.Name);



    }
}