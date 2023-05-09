namespace Demo44___ReadonlyKeyword;

public class Person
{
    // Fields
    private readonly int age;

    // Constructors

    public Person(int age, string firstname, string lastname)
    {
        this.age = age;
        Firstname = firstname;
        Lastname = lastname;
    }

    // Properties
    public string Firstname { get; set; }
    public string Lastname { get; set; }

    // Methods

    public int Age => age;

    // public void ChangeAge(int value)
    // {
    //     this.age = value;
    // }
}