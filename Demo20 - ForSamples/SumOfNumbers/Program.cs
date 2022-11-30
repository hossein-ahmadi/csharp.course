Console.WriteLine("Sum of numbers");
Console.WriteLine("------------------");
Console.WriteLine();
Console.Write("How many numbers: ");
int totalNumbers = int.Parse(Console.ReadLine());

int sum = 0;

for (int counter = 0; counter < totalNumbers; counter++)
{
    Console.Write($"Enter {counter + 1}st number: ");
    int number = int.Parse(Console.ReadLine());

    sum += number; // => sum = sum + number;
}

Console.WriteLine($"Sum of numbers: {sum}");
Console.WriteLine($"Average of numbers: {sum / 10}");