Console.WriteLine("Factorial");
Console.WriteLine("--------------------");
Console.WriteLine();

Console.Write("Enter a number to compute factorial: ");
int number = int.Parse(Console.ReadLine());

int result = number;
Console.Write($"{number}");
for (int counter = number - 1; counter > 0; counter--)
{
    Console.Write($" * {counter}");
    result = result 
             * counter;
}

Console.WriteLine($" = {result}");