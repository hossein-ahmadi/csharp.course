/*
 *  Demo10 - Type casting (Implicit and Explicit)
 *  CSharp Master Class (TOSINSO)
 *  Hossein Ahmadi
 */

Console.Write("First number: ");
int n1 = int.Parse(Console.ReadLine());
Console.Write("Second number: ");
int n2 = int.Parse(Console.ReadLine());

var result = n1 + n2;

Console.WriteLine(result);

// Implicit type casting

int n3 = 12;

long n4 = n3;

// Explicit type casting

long n5 = 23456;

int n6 = (int)n5;

// Parse method for type casting

var n7 = long.Parse("55223212256");
var n8 = decimal.Parse("52.366");

// ToString method

string n9 = 12.ToString();

decimal n10 = 5.23m;

string n10str = n10.ToString();