using Demo66___IoCandDI.ServicesAbstracts;

namespace Demo66___IoCandDI.Services;

public class FileLogger : ILogger
{
    public void WriteToLog(string message)
    {
        Console.WriteLine("write log to file: " + message);
    }
}