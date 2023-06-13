// Demo47
// Indexers

using Demo47___Indexers.Models;
using Demo47___Indexers.Services;

var repo = new EmployeeRepository();
repo.Add(new Employee()
{
    Id = "001",
    Firstname = "Hossein",
    Lastname = "Ahmadi"
});

repo.Add(new Employee()
{
    Id = "002",
    Firstname = "Mohammad",
    Lastname = "Nasiri"
});

Console.WriteLine(repo.Get(0).Firstname);

Console.WriteLine(repo[0].Lastname);

Console.WriteLine(repo["002"].Firstname);