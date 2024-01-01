namespace Demo101___ThreadsSynchronization;

public class PrintNumbers
{
    private static object printLock = new();

    public static void Print()
    {
        lock (printLock)
        {
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} started...");
        
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i} ");
            }
        
            Console.WriteLine();
        }

        // Monitor.Enter(printLock);
        // try
        // {
        //     Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} started...");
        //
        //     for (int i = 1; i <= 10; i++)
        //     {
        //         Console.Write($"{i} ");
        //     }
        //
        //     Console.WriteLine();
        // }
        // finally
        // {
        //     Monitor.Exit(printLock);
        // }
    }
}