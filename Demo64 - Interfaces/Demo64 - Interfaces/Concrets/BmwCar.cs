using Demo64___Interfaces.Abstracts;

namespace Demo64___Interfaces.Concrets;

public class BmwCar : Car, IEngine, IAudioSystem
{
    public string Name { get; set; }
    public string Brand { get; set; }

    public void Start()
    {
        Console.WriteLine("Engine started...");
    }

    public void Play()
    {
        Console.WriteLine("AudioSystem played...");
    }

    void IEngine.Stop()
    {
        Console.WriteLine("Engine stopped");
    }

    void IAudioSystem.Stop()
    {
        Console.WriteLine("Audio system stopped...");
    }

    public void Pause()
    {
        Console.WriteLine("Audio sytem paused...");
    }
}