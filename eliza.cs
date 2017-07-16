using System;
using dreamteam;

public class Eliza : Iteammate
{

    public string Specialty {get; set;} = ".Net MVC";
    public string FirstName {get; set;} = "Eliza";
    public string LastName {get; set;} = "Meeks";

    public string FullName {get => $"{this.FirstName} {this.LastName}";}

    public void Work() 
    {
        Console.WriteLine($"And God made {this.FirstName} ...... then dropped the mic");
    }
}