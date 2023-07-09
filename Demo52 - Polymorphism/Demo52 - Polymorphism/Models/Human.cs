namespace Demo52___Polymorphism.Models;

public class Human
{
    public string Name { get; set; }

    public virtual string Description { get; } = "This is a base class for human objects";

    public virtual void Speak()
    {
        Console.WriteLine("OOOOaaaaa");
    }

    public override string ToString()
    {
        return $"Human name is {Name}";
    }
}