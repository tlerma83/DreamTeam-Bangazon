using System;
using dreamteam;

public class Ollie : Iteammate
{
    public string Specialty {get; set;} = "All the things";
    public string FirstName {get; set;} = "Ollie";
    public string LastName {get; set;} = "OsinUsi";

    public string FullName {get => $"{this.FirstName} {this.LastName}";}

    public void Work()
    {
        Console.WriteLine($"{this.FirstName} will be the Maid of Honor at my 3rd wedding");
    }
}