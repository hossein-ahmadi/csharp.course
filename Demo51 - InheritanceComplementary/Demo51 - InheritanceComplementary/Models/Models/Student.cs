namespace Demo51___InheritanceComplementary.Models.Models;

public sealed class Student : Person
{
    public Student(string firstname, string lastname, byte age) : base(firstname, lastname, age)
    {

    }

    public string EducationalField { get; set; }

    public bool IsLegalAge()
    {
        return this.Age > 18;
    }
}

// Cannot create derived classes from sealed class

// public class SubStudent : Student
// {
//     public SubStudent(string firstname, string lastname, byte age) : base(firstname, lastname, age)
//     {
//     }
// }