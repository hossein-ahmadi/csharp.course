string firstName = "Hossein";
string lastName = "Ahmadi";

var fullName = firstName + " " + lastName;

var message1 = "Hello " + firstName + " " + lastName + ", Welcome to C# Master class!";

// String interpolation
var message2 = $"Helllo {firstName} {lastName}, Welcome to C# Master class!";

Console.WriteLine(fullName);
Console.WriteLine(message1);
Console.WriteLine(message2);


// Escapte characters
var message3 = "My Course is \"C# MasterClass\"";
var columns = "A\tB\tC\tD\r\nE\tF\tG\tH\t";

Console.WriteLine(message3);
Console.WriteLine(columns);