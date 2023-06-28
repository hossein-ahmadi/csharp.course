namespace Demo50___IsAsKeyword.Models;

public class Teacher : Person
{
    public Teacher(string firstname, string lastname, string educationalLevel) : base(firstname, lastname)
    {
        EducationalLevel = educationalLevel;
    }

    public string EducationalLevel { get; set; }
}