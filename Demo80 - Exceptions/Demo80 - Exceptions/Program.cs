// Demo80 - Exceptions
// TOSINSO C# Mega Course

try
{
    int number1 = int.Parse(Console.ReadLine());
    int number2 = int.Parse(Console.ReadLine());
    Console.WriteLine(number1 / number2);
}
catch (FormatException ex)
{
    Console.WriteLine("Input cannot be converted to int!");
}
catch (DivideByZeroException dex)
{
    Console.WriteLine("Divide by zero not allowed!");
}
catch(Exception ex)
{
    Console.WriteLine("Unknown error!");
}