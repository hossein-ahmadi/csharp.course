// Demo75 - Lambda Expressions
// TOSINSO C# Mega Course

Func<int, int, int> sumFunc = delegate (int n1, int n2)
{
    return n1 + n2;
};

Func<int, int, int> sumFuncWithLambda = (n1, n2) => n1 + n2;

string myName = "Hossein Ahmadi";

Action<string, int> repeatMessage = static delegate (string message, int repeat)
{
    // Console.WriteLine(myName); => Cannot use outer scope variables or objects in static anonymous methods or lambda expressions
    for (int i = 0; i < repeat; i++)
    {
        Console.WriteLine(message);
    }
};

Action<string, int> repeatMessageWithLambda = (message, repeat) =>
{
    for (int i = 0; i < repeat; i++)
    {
        Console.WriteLine(message);
    }
};

Console.WriteLine($"2 + 5 = {Calculate(2, 5, (n1, n2) => n1 + n2)}");

Console.WriteLine($"2 * 5 = {Calculate(2, 5, (n1, n2) => n1 * n2)}");

decimal Calculate(decimal n1, decimal n2, Func<decimal, decimal, decimal> logic)
{
    return logic(n1, n2);
}