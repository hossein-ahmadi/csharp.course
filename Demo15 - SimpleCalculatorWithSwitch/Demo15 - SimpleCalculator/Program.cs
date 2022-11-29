/*
 *  Demo15 - Simple calculator with switch statement
 *  CSharp Master Class (TOSINSO)
 *  Hossein Ahmadi
 */

Console.WriteLine("Welcome to TOSINSO Calculator");
Console.WriteLine("1[+]. Add");
Console.WriteLine("2[-]. Subtract");
Console.WriteLine("3[*]. Multiply");
Console.WriteLine("4[/]. Divide");
Console.WriteLine();
Console.Write("Please choose an option: ");
var option = Console.ReadLine();

if (option != "1" && option != "2" && option != "3" && option != "4"
    && option != "+" && option != "-" && option != "/" && option != "*")
{
    Console.WriteLine("You selected invalid option!");
    return;
}

Console.Write("First number: ");
var number1 = int.Parse(Console.ReadLine());
Console.Write("Second number: ");
var number2 = int.Parse(Console.ReadLine());

switch (option)
{
    case "1":
    case "+":
        Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
        break;
    case "2":
    case "-":
        Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
        break;
    case "3":
    case "*":
        Console.WriteLine($"{number1} * {number2} = {number1 * number2}");
        break;
    case "4":
    case "/":
        if (number2 == 0)
        {
            Console.WriteLine("Cannot divide by zero!");
            return;
        }
        Console.WriteLine($"{number1} / {number2} = {number1 / number2}");
        break;
}