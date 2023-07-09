namespace Demo52___Polymorphism.Models;

public class PersianHuman : Human
{
    public override void Speak()
    {
        Console.WriteLine("Salaam");
    }

    public override string Description { get; } = "This is persian human object";
}