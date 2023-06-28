namespace Demo49___ConstructorsInheritance.Models;

public class Person
{
    // public Person()
    // {
    //
    // }

    public Person(string firstname, string lastname)
    {
        Firstname = firstname; 
        Lastname = lastname;
    }

    public string Firstname { get; set; }
    public string Lastname { get; set; }

    public string Fullname => $"{Firstname} {Lastname}";
}