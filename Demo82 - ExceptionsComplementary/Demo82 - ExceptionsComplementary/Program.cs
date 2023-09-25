// Demo82 - Exceptions Complementary
// TOSINSO C# Mega Course

try
{
    Console.Write("Enter first number: ");
    int n1 = int.Parse(Console.ReadLine());
    Console.Write("Enter second number: ");
    int n2 = int.Parse(Console.ReadLine());

    Console.WriteLine($"{n1} / {n2} = {n1 / n2}");
}
catch (Exception ex) when (ex.Message.Contains("divide"))
{
    Console.WriteLine("Divide by zero is not allowed!");
}
catch (Exception ex) when (ex.Message.Contains("input string"))
{
    Console.WriteLine("Input string is not valid!");
}
finally
{
    Console.WriteLine("App ended!");
}