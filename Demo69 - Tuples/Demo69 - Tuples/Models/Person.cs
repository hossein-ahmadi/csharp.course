namespace Demo69___Tuples.Models;

public class Person
{
    public Person(string firstname, string lastname, int age)
    {
        Firstname = firstname;
        Lastname = lastname;
        Age = age;
    }

    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public int Age { get; set; }
}