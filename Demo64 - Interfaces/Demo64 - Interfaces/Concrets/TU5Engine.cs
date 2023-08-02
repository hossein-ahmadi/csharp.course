using Demo64___Interfaces.Abstracts;

namespace Demo64___Interfaces.Concrets;

public class TU5Engine : IEngine
{
    public void Start()
    {
        Console.WriteLine("Engine started");
    }

    public void Stop()
    {
        Console.WriteLine("Engine stopped");
    }
}