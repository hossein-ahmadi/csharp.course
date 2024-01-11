// Demo105 - Tasks
// TOSINSO C# Mega Course

var task = Task.Factory.StartNew(() =>
{
    for (int i = 0; i < 100; i++)
    {
        Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId}: {i}");
    }
});

task.Wait();

var task2 = Task.Run(() =>
{
    for (int i = 0; i < 100; i++)
    {
        Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId}: {i}");
    }
});

task2.Wait();

var ct = new CancellationTokenSource();
ParallelOptions poptions = new ParallelOptions();
poptions.CancellationToken = ct.Token;

Parallel.Invoke(poptions,() =>
{
    Console.WriteLine($"Running in thread: {Thread.CurrentThread.ManagedThreadId}");
}, () =>
{
    Console.WriteLine($"Running in thread: {Thread.CurrentThread.ManagedThreadId}");
}, () =>
{
    Console.WriteLine($"Running in thread: {Thread.CurrentThread.ManagedThreadId}");
}, () =>
{
    Console.WriteLine($"Running in thread: {Thread.CurrentThread.ManagedThreadId}");
});

ct.Cancel();

List<int> numbers = new List<int>();

for (int i = 0; i < 10000; i++)
{
    numbers.Add(i);
}

var q1result = numbers.AsParallel().Where(c=>c> 500);