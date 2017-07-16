using System;
using dreamteam;

public class Ryan : Iteammate
{
    public string Specialty {get; set;} = "C#, .Net Core";
    public string FirstName {get; set;} = "Ryan";
    public string LastName {get; set;} = "McCarty";

    public string FullName {get => $"{this.FirstName} {this.LastName}";}

    public void Work()
    {
        Console.WriteLine($"{this.FirstName} is so Metal he can make Metal with his Metal mind");
    }
}
