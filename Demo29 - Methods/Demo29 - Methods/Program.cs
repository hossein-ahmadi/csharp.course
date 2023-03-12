// C# Methods

DisplayMessage();
DisplayMessage();
DisplayMessage();


void DisplayMessage()
{
    Console.WriteLine("Welcome to TOSINSO.COM");
}

// Method with parameter

DisplayMessageWithParameters("Welcome to C# Master Class!");
DisplayMessageWithParameters("My name is Hossein Ahmadi!");

void DisplayMessageWithParameters(string message)
{
    Console.WriteLine(message);
}

// Method with multiple parameters

RepeatMessage("This is a message from TOSINSO.COM", 3);

void RepeatMessage(string message, int count)
{
    for (int counter = 0; counter < count; counter++)
    {
        Console.WriteLine(message);
    }
}

// Method with return type

Console.WriteLine(Sum(5, 3));

int Sum(int number1, int number2) // Signature => int Sum(int,int)
{
    int sum = number1 + number2;
    return sum;
}

int Sum2(int number1, int number2)
{
    return number1 + number2;
}

