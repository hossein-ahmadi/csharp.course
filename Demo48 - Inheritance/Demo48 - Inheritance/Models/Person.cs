namespace Demo48___Inheritance.Models;

public class Person
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }

    public string Fullname => $"{Firstname} {Lastname}";
}