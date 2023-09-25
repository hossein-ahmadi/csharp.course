// Demo81 - Custom Exceptions
// TOSINSO C# Mega Course

using Demo81___CustomExceptions;
using Demo81___CustomExceptions.Exceptions;

try
{
    Console.Write("Enter first number: ");
    int n1 = int.Parse(Console.ReadLine());
    Console.Write("Enter second number: ");
    int n2 = int.Parse(Console.ReadLine());

    Console.WriteLine($"{n1} / {n2} = {Calculator.Divide(n1, n2)}");
}
catch (CalculatorException ex)
{
    Console.WriteLine(ex.Message);
}