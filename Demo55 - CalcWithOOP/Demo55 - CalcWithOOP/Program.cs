// Demo55
// Calc with OOP

using Demo55___CalcWithOOP.Base;
using Demo55___CalcWithOOP.MathOperators;

while (true)
{
    Console.Clear();
    MathOperation operation = null;
    Console.WriteLine("Welcome to TOSINSO Calculator");
    Console.WriteLine("--------------------------------------");
    Console.WriteLine("1. Add");
    Console.WriteLine("2. Subtract");
    Console.WriteLine("3. Multiply");
    Console.WriteLine("4. Divide");
    Console.WriteLine("5. Exit");
    Console.WriteLine();

    Console.Write("Select an option: ");
    var selectedOption = Console.ReadLine();

    if (selectedOption != null && selectedOption == "5")
        return;
    Console.Clear();
    Console.Write("Enter first number: ");
    var firstNumber = decimal.Parse(Console.ReadLine());
    Console.Write("Enter second number: ");
    var secondNumber = decimal.Parse(Console.ReadLine());
    switch (selectedOption)
    {
        case "1":
            operation = new AddOperator(firstNumber, secondNumber);
            break;
        case "2":
            operation = new SubtractOperator(firstNumber, secondNumber);
            break;
        case "3":
            operation = new MultiplyOperator(firstNumber, secondNumber);
            break;
        case "4":
            operation = new DivideOperator(firstNumber, secondNumber);
            break;
        default:
            Console.WriteLine("Invalid option!");
            Console.ReadKey();
            continue;
    }

    if (operation != null)
    {
        if (!operation.Validate())
        {
            Console.WriteLine("Invalid inputs!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            continue;
        }
        var result = operation.Operate();

        Console.WriteLine($"Result: {result}");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}