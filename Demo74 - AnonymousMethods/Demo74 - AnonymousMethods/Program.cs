// Demo74 - Anonymous Methods
// TOSINSO C# Mega Course

using Demo74___AnonymousMethods.Models;
using Demo74___AnonymousMethods.Repositories;

Func<int, int, int> sumFunc = delegate(int n1, int n2)
{
    return n1 + n2;
};

Action<string, int> repeatMessage = delegate(string message, int repeat)
{
    for (int i = 0; i < repeat; i++)
    {
        Console.WriteLine(message);
    }
};

repeatMessage("Welcome to TOSINSO.COM", 4);

Console.WriteLine(sumFunc(5, 3));

var repo = new StudentsRepository();

repo.OnAddStudent += delegate(Student student)
{
    Console.WriteLine($"Student {student.Firstname} {student.Lastname} added to database!");
};

repo.Add(new Student()
{
    Id = 1,
    Firstname = "Mehdi",
    Lastname = "Adeli",
    Age = 30
});