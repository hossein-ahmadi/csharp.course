namespace Demo51___InheritanceComplementary.Models.Models;

public class Teacher : Person
{
    public Teacher(string firstname, string lastname, string educationalLevel, byte age) : base(firstname, lastname, age)
    {
        EducationalLevel = educationalLevel;
    }

    public string EducationalLevel { get; set; }
}