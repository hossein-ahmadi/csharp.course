// Demo101 - Threads Synchronization
// TOSINSO C# Mega Course

using Demo101___ThreadsSynchronization;

Thread[] threads = new Thread[10];

for (int i = 0; i < 10; i++)
{
    threads[i] = new Thread(PrintNumbers.Print);
}

foreach (var thread in threads)
{
    thread.Start();
}

object mutex = new();

int num = 12;

Interlocked.Increment(ref num);
Interlocked.Add(ref num, 12);
Interlocked.Decrement(ref num);