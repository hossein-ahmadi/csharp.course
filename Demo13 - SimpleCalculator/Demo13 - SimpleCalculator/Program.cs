// Simple calculator

Console.WriteLine("Welcome to TOSINSO Calculator");
Console.WriteLine("1. Add");
Console.WriteLine("2. Subtract");
Console.WriteLine("3. Multiply");
Console.WriteLine("4. Divide");
Console.WriteLine();
Console.Write("Please choose an option: ");
var option = Console.ReadLine();

if (option != "1" && option != "2" && option != "3" && option != "4")
{
    Console.WriteLine("You selected invalid option!");
    return;
}

Console.Write("First number: ");
var number1 = int.Parse(Console.ReadLine());
Console.Write("Second number: ");
var number2 = int.Parse(Console.ReadLine());

if (option == "1")
{
    Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
}
else if (option == "2")
{
    Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
}
else if (option == "3")
{
    Console.WriteLine($"{number1} * {number2} = {number1 * number2}");
}
else if (option == "4")
{
    if (number2 == 0)
    {
        Console.WriteLine("Cannot divide by zero!");
        return;
    }
    Console.WriteLine($"{number1} / {number2} = {number1 / number2}");
}