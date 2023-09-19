// Demo77 - Anonymous types
// TOSINSO C# Mega Course

var student = new
{
    Id = 1,
    Firstname = "Hossein",
    Lastname = "Ahmadi",
    Address = new
    {
        State = "Alborz",
        City = "Karaj"
    }
};

// student.Firstname = "test"; not allowed
var student2 = student with
{
    Firstname = "Mehdi",
    Lastname = "Adeli",
    // Age = 12 adding new properties not allowed
};

Console.WriteLine(student2);