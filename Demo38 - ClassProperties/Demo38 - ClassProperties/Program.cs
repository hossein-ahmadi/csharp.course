// Demo38 - ClassProperties

var std = new Student();
// std.set_Firstname("Hossein");
std.Firstname = "Hossein";
std.Lastname = "Ahmadi";

// cannot assign value to read only properties
// std.Fullname = "Mohammad Nasiri";

Console.WriteLine(std.Firstname);
Console.WriteLine(std.Age);
Console.WriteLine(std.Fullname);

class Student
{
    private string firstname;
    // private string lastname;

    // public string get_Firstname()
    // {
    //     return firstname;
    // }
    //
    // public void set_Firstname(string value)
    // {
    //
    // }

    public string Firstname
    {
        get => firstname;
        // get
        // {
        //     return firstname;
        // }
        set
        {
            if (value.Length < 5 || value.Length > 15)
            {
                throw new Exception("Firstname length must be between 5 and 15 characters.");
            }
            firstname = value;
        }
    }

    // Auto property with default value
    public byte Age { get; set; } = 20;


    // Auto property
    public string Lastname { get; set; }

    // public string Lastname
    // {
    //     get
    //     {
    //         return lastname;
    //     }
    //     set
    //     {
    //         lastname = value;
    //     }
    // }

    // Property declaration with expression body
    public string Fullname => $"{Firstname} {Lastname}";

    // public string Fullname
    // {
    //     get
    //     {
    //         return $"{Firstname} {Lastname}";
    //     }
    // }
}