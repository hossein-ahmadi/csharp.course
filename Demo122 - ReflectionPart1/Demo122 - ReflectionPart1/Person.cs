namespace Demo122___ReflectionPart1;

public class Person
{
    // private string firstName;
    //
    // public string get_Firstname()
    // {
    //     return firstName;
    // }
    //
    // public void set_Firstname(string value)
    // {
    //     firstName = value;
    // }

    public string Firstname { get; set; }
    public string Lastname { get; set; }

    public string GetFullname()
    {
        return $"{Firstname} {Lastname}";
    }
}