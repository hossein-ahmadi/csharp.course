// Method parameters

RepeatMessage(count: 4, message: "Welcome to TOSINSO"); // Call method by parameter names

RepeatMessage("C# Master class"); // optional parameters

void RepeatMessage(string message, int count = 2)
{
    for (int counter = 0; counter < count; counter++)
    {
        Console.WriteLine(message);
    }
}