namespace Demo70___DeconstructingTypes.Models;

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

    public void Deconstruct(out string firstname, out string lastname)
    {
        firstname = this.Firstname;
        lastname = this.Lastname;
    }

    public void Deconstruct(out string firstname, out string lastname, out int age)
    {
        firstname = this.Firstname;
        lastname = this.Lastname;
        age = this.Age;
    }
}