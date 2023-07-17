namespace Demo56___StaticClasses;

public class Person
{
    public Person()
    {
        Instances++;
    }

    static Person()
    {
    }

    public static int Instances { get; private set; }

    public string Firstname { get; set; }
    public string Lastname { get; set; }

    public static Person Create(string firstName, string lastName)
    {
        return new Person { Firstname = firstName, Lastname = lastName };
    }
}