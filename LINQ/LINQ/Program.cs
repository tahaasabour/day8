



using System;
using System.Collections.Generic;




public class Program
{
    public static void Main()
    {

        SuperList<Trainee> sL = new SuperList<Trainee>()
        {
            new Trainee{Id=1, Name="Samaa", Mobile ="3434343"},
            new Trainee{Id=3, Name="Ahmed", Mobile ="3434343"},
            new Trainee{Id=100, Name="Mostafa", Mobile ="3434343"},
            new Trainee{Id=9, Name="Galal", Mobile ="3434343"},
        };



        var result2 =
                    sL.WhereMethod(i => i.Id > 7).TakeMethod(2)
                    .SelectMethod(i => new  { NameOfTrainee = i.Name,  i.Id});


        //IEnumerable<Trainee> result3 =
        //     QueryMethods.TakeMethod(
        //         QueryMethods.WhereMethod(sL, i => i.Id > 7)
        //         , 2);


        foreach (var e in result2)
            Console.WriteLine(e.Id+", "+ e.NameOfTrainee);


    }
}