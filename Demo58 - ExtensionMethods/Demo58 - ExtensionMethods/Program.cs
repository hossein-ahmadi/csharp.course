// Demo58 - Extension Methods
// TOSINSO C# Mega Course

using Demo58___ExtensionMethods;
using Demo58___ExtensionMethods.ExtensionMethods;

Person person = new Person()
{
    Firstname = "Hossein",
    Lastname = "Ahmadi"
};

Console.WriteLine(person.Fullname());

Console.WriteLine(person.WelcomeMessage("C# Developer"));