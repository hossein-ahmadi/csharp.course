namespace Demo54___AbstractClasses.Models;

public class Teacher : Person
{
    public override string GetInfo()
    {
        return $"{Firstname} {Lastname} is a teacher!";
    }
}