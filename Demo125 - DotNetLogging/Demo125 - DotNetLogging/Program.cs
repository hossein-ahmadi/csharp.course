using Microsoft.Extensions.Logging;

namespace Demo125___DotNetLogging;

internal partial class Program
{
    public static ILoggerFactory Factory;

    public static void Main(string[] args)
    {
        Factory = LoggerFactory.Create(builder =>
        {
            builder.AddProvider(new FileLoggerProvider());
        });

        var calculator = new Calculator();

        Console.Write("First number: ");
        var n1 = decimal.Parse(Console.ReadLine()!);
        Console.Write("Second number: ");
        var n2 = decimal.Parse(Console.ReadLine()!);


        Console.WriteLine($"{n1} / {n2} = {calculator.Divide(n1, n2)}");

        Console.ReadKey();
    }
}

public class Calculator
{
    public decimal Divide(decimal n1, decimal n2)
    {
        try
        {
            return n1 / n2;
        }
        catch (Exception e)
        {
            var logger = Program.Factory.CreateLogger<Calculator>();
            logger.LogError(e, e.Message);
            Console.WriteLine("Something is going wrong!");
            return 0;
        }
    }
}

public class FileLoggerProvider : ILoggerProvider
{
    public void Dispose()
    {
        
    }

    public ILogger CreateLogger(string categoryName)
    {
        return new FileLogger();
    }
}

public class FileLogger : ILogger
{
    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
    {
        File.AppendAllText("d:\\applog.txt", formatter(state, exception) + Environment.NewLine);
    }

    public bool IsEnabled(LogLevel logLevel)
    {
        return true;
    }

    public IDisposable? BeginScope<TState>(TState state) where TState : notnull
    {
        return default!;
    }
}