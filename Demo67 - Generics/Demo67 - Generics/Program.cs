// Demo67 - Generics
// TOSINSO C# Mega Course


using Demo67___Generics.Entities;
using Demo67___Generics.Services;

var h1 = new ValueHolder<int>(12);

Console.WriteLine(h1.Value);

var h2 = new ValueHolder<string>("Welcome");

Console.WriteLine(h2.Value);

var mvh1 = new MultiValueHolder<int, string>(12, "TOSINSO.COM");

DisplayToOutput(12);
DisplayToOutput("Welcome");

var personsRepo = new GenericRepository<Person>();

personsRepo.Add(new Person());

T DisplayToOutput<T>(T value)
{
    Console.WriteLine(value);
    return default(T);
}

public class ValueHolder<TValue>
{
    public ValueHolder(TValue value)
    {
        Value = value;
    }

    public TValue Value { get; set; }
}

public class MultiValueHolder<TValue1, TValue2>
{
    public MultiValueHolder(TValue1 value1, TValue2 value2)
    {
        Value1 = value1;
        Value2 = value2;
    }

    public TValue1 Value1 { get; set; }
    public TValue2 Value2 { get; set;}
}

