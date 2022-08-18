// [datatype] [name];
// [datatype] [name] = [value];

string fullname = "Hossein Ahmadi from TOSINSO";

string message;
message = "Welcome to C# Master Class!";

Console.WriteLine("Hello, World!");
Console.WriteLine("------------------");
Console.WriteLine(message);
Console.WriteLine(fullname);
Console.WriteLine(fullname);

// variable names
// string 02myName = "Hossein"; invalid variable declaration
// string my-name = "Hossein";  invalid variable declaration
string _myName = "Hossein"; // valid

string thisIsMyVariable; // camelCase -> use this method
string ThisIsMyVariable; // PascalCase

// case sensitive
string MyVariable;
string myVariable;

// multiple variables in single declaration
string n1 = "Value1", n2 = "Value2", n3;
n3 = "Value3";

Console.WriteLine(n1);
Console.WriteLine(n2);
Console.WriteLine(n3);

// invalid assignment
// string number1 = 123;

// using keywords in variable names

// string for = "Welcome"; invalid variable name

string @for = "Welcome";

Console.WriteLine(@for);