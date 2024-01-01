// Demo103 - Thread Pools
// TOSINSO C# Mega Course

ThreadPool.QueueUserWorkItem(state =>
{
    for (int i = 0; i < 100; i++)
    {
        Console.WriteLine(i);
    }
});

Console.WriteLine("Press any key to exit!");
Console.ReadKey();