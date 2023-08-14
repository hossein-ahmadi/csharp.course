// Demo69 - Tuples
// TOSINSO C# Mega Course
// Hossein Ahmadi

using Demo69___Tuples.Models;

var values = new Tuple<int,int>(12,20);

(int,int) tuple1 = (12,20);

var tuple2 = ("Hossein", "Ahmadi", 37);

tuple1.Item1 = 18;
Console.WriteLine(tuple1.Item1);

(string firstname, string lastname, int age) person1 = ("Hossein", "Ahmadi", 37);
(string firstname, string lastname, int age) person2 = (firstname: "Hossein", lastname: "Ahmadi", age: 37);

var person3 = new Person("Mohammad", "Nasiri", 37);

var person4 = (person3.Firstname, person3.Lastname, person3.Age);

var result = Calc(9, 6);

Console.WriteLine($"{result.sum}, {result.subtract}, {result.multiply}, {result.divide}");

// Discards
var (sum, _, multiply, _) = Calc(8, 4);

(int sum, int subtract, int multiply, int divide) Calc(int n1, int n2)
{
    return (n1 + n2, n1 - n2, n1 * n2, n1 / n2);
}

// Deconstructing tuples

var person = ("Alireza", "Fazeli", 32);

var (firstname, lastname, age) = person;

Console.WriteLine($"{firstname} {lastname} is {age} years old!");