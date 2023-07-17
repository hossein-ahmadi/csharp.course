// Demo56
// Static classes

using Demo56___StaticClasses;

Console.WriteLine(ValueHolder.Value);

ValueHolder.Value = 12;

Console.WriteLine(ValueHolder.Value);


Console.WriteLine($"Person instances: {Person.Instances}");
var person = Person.Create("Hossein", "Ahmadi");
Console.WriteLine($"Person instances: {Person.Instances}");
var person2 = Person.Create("Hossein", "Ahmadi");
var person3 = Person.Create("Hossein", "Ahmadi");
Console.WriteLine($"Person instances: {Person.Instances}");