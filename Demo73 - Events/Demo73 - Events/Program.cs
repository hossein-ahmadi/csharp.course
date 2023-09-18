// Demo73 - Events
// TOSINSO C# Mega Course

using Demo73___Events.Models;
using Demo73___Events.Repositories;

var repo = new StudentsRepository();

repo.OnAddStudent += OnStudentAdded;
repo.OnAddStudent += SendEmailOnStudentAdded;

repo.OnDeleteStudent += OnDeleteStudent;

repo.OnUpdateStudent += OnUpdateStudent;

var newStudent = new Student()
{
    Id = 1,
    Firstname = "Hossein",
    Lastname = "Ahmadi",
    Age = 37
};
repo.Add(newStudent);

repo.Update(newStudent);

repo.Delete(3);


void OnStudentAdded(Student student)
{
    Console.WriteLine($"Student: {student.Firstname} {student.Lastname} added to database.");
}

void SendEmailOnStudentAdded(Student student)
{
    Console.WriteLine("Email sent to h.ahmadi@live.com");
}

void OnDeleteStudent(object? sender, Student student)
{
    Console.WriteLine($"student {student.Firstname} {student.Lastname} deleted from database!");
}

void OnUpdateStudent(object? sender, OnUpdateStudentEventArgs args)
{
    if (args.Success)
    {
        Console.WriteLine($"Student {args.Student.Firstname} {args.Student.Lastname} updated...");
    }
    else
    {
        Console.WriteLine($"Update operation for student {args.Student.Firstname} {args.Student.Lastname} failed!");
    }
}