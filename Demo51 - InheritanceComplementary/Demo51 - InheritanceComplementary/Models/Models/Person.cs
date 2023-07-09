namespace Demo51___InheritanceComplementary.Models.Models;

public class Person
{
    public Person(string firstname, string lastname, byte age)
    {
        Firstname = firstname; 
        Lastname = lastname;
        Age = age;
    }

    public string Firstname { get; set; }
    public string Lastname { get; set; }

    protected byte Age { get; set; }

    public string Fullname => $"{Firstname} {Lastname}";
}