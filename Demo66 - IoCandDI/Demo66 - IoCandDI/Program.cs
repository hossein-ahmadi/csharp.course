// Demo66 - Inversion of Control (IoC) and Dependency Injection (DI)
// TOSINSO C# Mega Course

using Demo66___IoCandDI;
using Demo66___IoCandDI.Models;
using Demo66___IoCandDI.Services;

var repo = new StudentsRepository(new DatabaseLogger());

var student = new Student()
{
    Id = 1,
    Name = "Hossein Ahmadi"
};

repo.Add(student);
repo.Delete(1);
repo.Update(student);