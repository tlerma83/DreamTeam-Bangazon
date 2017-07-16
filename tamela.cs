using System;
using dreamteam;

public class Tamela  : Iteammate
{
    public string Specialty {get; set;} ="Angular";
    public string FirstName {get; set;} = "Tamela";
    public string LastName {get; set;} = "Lerma";

    public string FullName {get => $"{this.FirstName} {this.LastName}";}

    public void Work()
    {
        Console.WriteLine($"{this.FirstName} will be selling Madeline's hair on the black market if she can't get a job");
    }
}