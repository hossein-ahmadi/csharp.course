namespace Demo54___AbstractClasses.Models;

public abstract class Person
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }

    public abstract string GetInfo();
}