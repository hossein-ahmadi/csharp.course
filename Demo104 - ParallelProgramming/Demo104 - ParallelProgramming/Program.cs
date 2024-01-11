// Demo104 - Parallel Programming
// TOSINSO C# Mega Course

List<int> numbers = new List<int>(10_000);

object mutex = new object();

Parallel.For(0,10_000, i =>
{
    // Console.WriteLine($"Thread Id: {Thread.CurrentThread.ManagedThreadId}");
    lock (mutex)
    {
        numbers.Add(i);
    }
});

int sum = 0;

var result = Parallel.ForEach(numbers, i =>
{
    lock (mutex)
    {
        sum = sum + i;
    }
});

while(!result.IsCompleted){}

Console.WriteLine(sum);

Console.ReadKey();