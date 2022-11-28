/*
 *  Demo09 - Input from console
 *  CSharp Master Class (TOSINSO)
 *  Hossein Ahmadi
 */

Console.Write("Your firstname: ");
var firstName = Console.ReadLine();
Console.Write("Your lastname: ");
var lastName = Console.ReadLine();


var message = $"Hello {firstName} {lastName}, Welcome to C# Master Class!";

Console.WriteLine(message);

Console.WriteLine("----------------------------------");

// int number1 = Console.ReadLine(); => Raise an error

Console.Write("First number: ");
string number1 = Console.ReadLine();
Console.Write("Second number: ");
string number2 = Console.ReadLine();

var sum = number1 + number2;

Console.WriteLine($"Sum of {number1} and {number2} is {sum}");