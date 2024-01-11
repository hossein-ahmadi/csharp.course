// Demo106 - Async and Await
// TOSINSO C# Mega Course

var average = await CalculateAverageAsync(10, 20, 14, 5, 15, 18, 11, 17, 10);

Console.WriteLine($"Average: {average}");

await DisplayOutputAsync();

async Task<int> CalculateAverageAsync(params int[] numbers)
{
    return await Task.Run(() =>
    {
        int sum = 0;

        foreach (var number in numbers)
        {
            sum += number;
        }

        return sum / numbers.Length;
    });
}

async Task DisplayOutputAsync()
{
    await Task.Run(() =>
    {
        Console.WriteLine("Welcome to TOSINSO.COM");
    });
}