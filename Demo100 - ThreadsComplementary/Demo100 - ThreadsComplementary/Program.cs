// Demo100 - Threads Complementary
// TOSINSO C# Mega Course

AutoResetEvent resetEvent = new AutoResetEvent(false);

Thread thread = new Thread(() =>
{
    for (int i = 0; i < 1000; i++)
    {
        Console.WriteLine(i);
    }

    resetEvent.Set();
});

thread.Start();

resetEvent.WaitOne();
Console.WriteLine("End of application");