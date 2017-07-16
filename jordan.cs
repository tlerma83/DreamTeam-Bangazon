using System;
using dreamteam;

public class Jordan : Iteammate
{
    public string Specialty {get; set;} = "TDD";
    public string FirstName {get; set;} = "Jordan";
    public string LastName {get; set;} = "Dhaenens";

    public string FullName {get => $"{this.FirstName} {this.LastName}";}

    public void Work()
    {
        Console.WriteLine($"The original Dos Equis man who he eats lots of weird shit ... {this.FirstName} don't eat the bones man!");
    }
}