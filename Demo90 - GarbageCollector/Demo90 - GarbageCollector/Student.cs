namespace Demo90___GarbageCollector;

public class Student : IDisposable
{
    private bool disposed = false;

    public void Dispose()
    {
        Cleanup(true);
        GC.SuppressFinalize(this);
    }

    private void Cleanup(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                // Cleanup managed resources
            }
            // Cleanup unmanaged resources
            disposed = true;
        }
    }

    ~Student()
    {
        Cleanup(false);
    }
}