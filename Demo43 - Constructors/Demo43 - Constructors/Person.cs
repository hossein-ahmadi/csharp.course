namespace Demo43___Constructors;

public class Person
{
    public Person(){}

    public Person(string firstname, string lastname, int age)
    {
        if (firstname.Length > 20)
            throw new ArgumentException();
        this.Firstname = firstname;
        this.Lastname = lastname;
        this.Age = age;
    }

    public Person(string firstname, string lastname) : this(firstname, lastname, 0)
    {
    }

    public string Firstname { get; set; }
    public string Lastname { get; set; }

    public int Age { get; set; }
}