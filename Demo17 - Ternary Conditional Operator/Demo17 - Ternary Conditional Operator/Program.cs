/*
 *  Demo17 - Ternary Conditional Operator
 *  CSharp Master Class (TOSINSO)
 *  Hossein Ahmadi
 */

Console.Write("Enter a number: ");
var inputIsNumber = int.TryParse(Console.ReadLine(), out var number);
if (!inputIsNumber)
{
    Console.WriteLine("Input is not in valid format!");
    return;
}

var message = number % 2 == 0 ? "Number is even!" : "Number is odd!";
Console.WriteLine(message);

// number % 2 == 0 ? Console.WriteLine("Number is even!") : Console.WriteLine("Number is odd!"); => invalid syntax