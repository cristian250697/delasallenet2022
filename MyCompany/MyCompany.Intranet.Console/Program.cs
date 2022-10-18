using System;
using MyCompany.Intranet.Core.Entities;
using MyCompany.Intranet.Core.Enums;
using MyCompany.Intranet.Core.Managers;
using MyCompany.Intranet.Core.Services;

namespace MyCompany.Intranet.Console;

public static class Program
{
    // One line comment 
    public static void Main(string[] args)
    {
        float height = 0;
        float weight = 0;

        System.Console.WriteLine("Please enter the Weight: ");
        Single.TryParse(System.Console.ReadLine(), out weight);

        System.Console.WriteLine("Please enter the Height: ");
        Single.TryParse(System.Console.ReadLine(), out height);

        
        var person = new Person{ Weight = weight, Height = height};
       
        var service = new ApiBmiService();
        var manager = new BmiManager(service);       

        Bmi bmi = manager.GetBmi(person);

        System.Console.WriteLine($"BMI {bmi.Index} Type {bmi.BmiType}");

    }

} 


