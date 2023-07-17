// OOP Complementary subjects
// TOSINSO C# Mega Course

using Demo61___OOPComplementary.PartialClass;

Student? st1 = new Student()
{
    Id = 1,
    Firstname = "Hossein",
    Lastname = "Ahmadi"
};

Student? st2 = null;

// usage of nested types
var studentAddress = new Student.StudentAddress();

// nameof keyword
Console.WriteLine(nameof(Student.Firstname));

// Null coalesce
Student currentStudent = st2 ?? st1;
Console.WriteLine((st2 ?? st1).Firstname);

// Null conditional

Console.WriteLine(st2?.Firstname ?? "Value is null");

// Null coalesce assignment
st2 ??= new  Student();