// Demo122 - Reflection Part 1
// TOSINSO C# Mega Course

using System.Reflection;
using Demo122___ReflectionPart1;

// var person = new Person();
// var personType = person.GetType();

var personType = typeof(Person);

Console.WriteLine($"Assembly: {personType.Assembly.FullName}");

var properties = personType.GetProperties();

foreach (var property in properties)
{
    Console.WriteLine($"Property: {property.Name}");
}

var methods = personType.GetMethods(BindingFlags.Instance | BindingFlags.DeclaredOnly | BindingFlags.Public);

foreach (var method in methods)
{
    if(method.IsSpecialName)
        continue;
    Console.WriteLine($"Method: {method.Name}");
}