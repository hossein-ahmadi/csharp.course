/*
 *  Demo14 - Switch statement
 *  CSharp Master Class (TOSINSO)
 *  Hossein Ahmadi
 */

Console.Write("Enter a character: ");
var option = Console.ReadLine();

switch (option)
{
    case "A":
    case "a":
        Console.WriteLine("You entered character a");
        break;
    case "B":
    case "b":
        Console.WriteLine("You entered character b");
        break;
    default:
        Console.WriteLine("You entered other characters!");
        break;
}

if (option == "a" || option == "A")
{
    Console.WriteLine("You enter character a");
}
else if (option == "b" || option == "B")
{
    Console.WriteLine("You enter character b");
}
else
{
    Console.WriteLine("You entered other characters");
}