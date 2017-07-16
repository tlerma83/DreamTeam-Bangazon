using System;
using dreamteam;

public class Jackie : Iteammate
{
    public string Specialty {get; set;} = "JavaScript";
    public string FirstName {get; set;} = "Jackie";
    public string LastName {get; set;} = "Knight";
    public string FullName {get => $"{this.FirstName} {this.LastName}";}
    public void Work() 
    {
        Console.WriteLine($"Don't be putting salt on {this.FirstName}'s watermelon");
    }
}