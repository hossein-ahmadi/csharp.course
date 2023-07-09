namespace Demo52___Polymorphism.Models;

public class EnglishHuman : Human
{
    public sealed override void Speak()
    {
        Console.WriteLine("Hello!");

        // Call base method implementation
        // base.Speak();
    }
}

public class AmericanHuman : EnglishHuman
{
    // Cannot override sealed methods
    // public override void Speak()
    // {
    //     base.Speak();
    // }
}