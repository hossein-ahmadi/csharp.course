// Boolean Data Type

// Declaration

bool trueValue = true;
bool falseValue = false;

// Boolean Logical Operators
Console.Write("Please enter a number: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"{number} < 10: {number < 10}");
Console.WriteLine($"{number} <= 10: {number <= 10}");
Console.WriteLine($"{number} > 10: {number > 10}");
Console.WriteLine($"{number} >= 10: {number >= 10}");
Console.WriteLine($"{number} == 20: {number == 20}");
Console.WriteLine($"{number} != 20: {number != 20}");

// Boolean Conditional Operator

bool result1 = number >= 10 && number <= 20;
bool result2 = number >= 10 || number <= 20;
Console.WriteLine($"Number is between 10 and 20: {result1}");
Console.WriteLine($"Number is greater than 10 or lower than 20: {result2}");

var notResult1 = !result1;
Console.WriteLine($"not result1: {notResult1}");

var result3 = (number > 10 || number < 20) && number <= 10;