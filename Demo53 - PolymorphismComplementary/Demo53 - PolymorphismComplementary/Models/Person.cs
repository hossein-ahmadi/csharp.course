namespace Demo53___PolymorphismComplementary.Models;

public class Person
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }

    public byte Age { get; set; }

    public virtual Person Clone()
    {
        var person = Create();
        person.Firstname = this.Firstname;
        person.Lastname = this.Lastname;
        person.Age = this.Age;
        return person;
    }

    protected virtual Person Create() => new Person();

    public string GetDisplayString()
    {
        return $"{Firstname} {Lastname} is a person.";
    }
}