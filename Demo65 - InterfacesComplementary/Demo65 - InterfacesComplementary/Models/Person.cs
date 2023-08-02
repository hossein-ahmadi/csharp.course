namespace Demo65___InterfacesComplementary.Models;

public class Person : IComparable, ICloneable
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

    public override string ToString()
    {
        return $"{Firstname} {Lastname} is {Age} years old.";
    }

    public object Clone()
    {
        return new Person(Firstname, Lastname, Age);
    }

    public int CompareTo(object? obj)
    {
        if (obj is Person p)
        {
            if(p.Age < this.Age)
                return -1;
            if(p.Age == this.Age) 
                return 0;
            return 1;
        }

        return 0;
    }
}