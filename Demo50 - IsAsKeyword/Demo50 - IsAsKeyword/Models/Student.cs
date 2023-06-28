namespace Demo50___IsAsKeyword.Models;

public class Student : Person
{
    public Student(string firstname, string lastname) : base(firstname, lastname)
    {

    }

    public string EducationalField { get; set; }
}