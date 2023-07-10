namespace Demo53___PolymorphismComplementary.Models;

public class Student : Person
{
    public string EducationalField { get; set; }

    public override Student Clone()
    {
        var cloned = (Student)base.Clone();
        cloned.EducationalField = EducationalField;
        return cloned;
    }

    protected override Student Create() => new Student();

    public new string GetDisplayString()
    {
        return $"{Firstname} {Lastname} is a student!";
    }
}