/*
 *  Demo22 - While loop sample
 *  CSharp Master Class (TOSINSO)
 *  Hossein Ahmadi
 */

while (true)
{
    Console.Clear();
    Console.WriteLine("Welcome to TOSINSO Calculator");
    Console.WriteLine("---------------------------------");
    Console.WriteLine("1. Add");
    Console.WriteLine("2. Subtract");
    Console.WriteLine("3. Multiply");
    Console.WriteLine("4. Divide");
    Console.WriteLine("5. Exit");
    Console.WriteLine();
    Console.Write("Select an option: ");
    var option = Console.ReadLine();

    if (!int.TryParse(option, out int optionAsNumber) || optionAsNumber < 1 || optionAsNumber > 5)
    {
        Console.Write("Please select a valid option! Press any key to return to the menu...");
        Console.ReadKey();
        continue;
    }

    if (option == "5")
    {
        break;
    }

    Console.Write("First number: ");
    if (!int.TryParse(Console.ReadLine(), out var number1))
    {
        Console.WriteLine("Please enter valid number! Press any key to return to the menu...");
        Console.ReadKey();
        continue;
    }

    Console.Write("Second number: ");
    if (!int.TryParse(Console.ReadLine(), out var number2))
    {
        Console.WriteLine("Please enter valid number! Press any key to return to the menu...");
        Console.ReadKey();
        continue;
    }

    switch (option)
    {
        case "1":
            Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
            break;
        case "2":
            Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
            break;
        case "3":
            Console.WriteLine($"{number1} * {number2} = {number1 * number2}");
            break;
        case "4":
            if (number2 == 0)
            {
                Console.WriteLine("Can't divide by zero! Press any key to return to the menu...");
                Console.ReadKey();
                continue;
            }
            Console.WriteLine($"{number1} / {number2} = {number1 / number2}");
            break;
    }

    Console.WriteLine("Press any key to return to the menu...");
    Console.ReadKey();
}