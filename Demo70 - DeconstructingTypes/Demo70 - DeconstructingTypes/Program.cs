// Demo70 - Deconstructing types
// TOSINSO C# Mega Course
// Hossein Ahmadi

using Demo70___DeconstructingTypes.Models;

var person = ("Hossein", "Ahmadi", 37);

var person2 = new Person("Mohammad", "Nasiri", 37);

var (firstname, lastname, age) = person;

var (fn, ln, a) = person2;

var (fn2, ln2) = person2;

Console.WriteLine($"{fn} {ln} {a}");