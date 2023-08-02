// Demo 75 - Interfaces Complementary
// TOSINSO C# Mega Course

using Demo65___InterfacesComplementary.Models;
using Demo65___InterfacesComplementary.Repositories;

var persons = new[]
{
    new Person("Hossein","Ahmadi",37),
    new Person("Mohammad","Nasiri",24),
    new Person("Ali","Shokrollahi",33),
    new Person("Mehdi","Adeli",25),
    new Person("Alireza","Fazeli",20)
};

Array.Sort(persons);

foreach (var person in persons)
{
    Console.WriteLine(person.ToString());
}

PersonRepository repo = new PersonRepository();

foreach (var person in persons)
{
    repo.Add(person);
}

foreach (var p in repo)
{
    Console.WriteLine(p.ToString());
}