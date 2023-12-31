// Demo99 - Threads
// TOSINSO C# Mega Course

using Demo99___Threads.Models;

ThreadStart ts1 = () =>
{
    for (int counter = 0; counter < 100; counter++)
    {
        Console.WriteLine(counter);
    }
};

ParameterizedThreadStart pts = input =>
{
    var tim = (ThreadInputModel)input;

    for (int counter = tim.From; counter < tim.To; counter++)
    {
        Thread.Sleep(1000);
        Console.WriteLine(counter);
    }
};

Thread thread1 = new Thread(ts1)
{
    Priority = ThreadPriority.Highest
};
Thread thread2 = new Thread(pts);

thread1.Start();

thread2.Start(new ThreadInputModel(200,300));