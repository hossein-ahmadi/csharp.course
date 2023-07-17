// Demo60 - Structs
// TOSINSO C# Mega Course

ValueHolder1 holder = new ValueHolder1(12);
holder.Value = 20;

ValueHolder2 holder2 = new ValueHolder2(20);
// holder2.Value = 20; Can't change value of readonly structs

ValueHolder3 holder3 = new ValueHolder3(30);
// holder3.Value = 40; Can't change value of readonly properties in structs


// object boxedHolder = holder; => Cannot box ref structs


public ref struct ValueHolder1
{
    public ValueHolder1(int value)
    {
        this.Value = value;
    }

    public int Value { get; set; }

    public override string ToString()
    {
        return $"Value: {Value}";
    }
}


// You can create immutable structs with readonly keyword
public readonly struct ValueHolder2
{
    public ValueHolder2(int value)
    {
        this.Value = value;
    }

    public int Value { get; init; }
}

// You can create readonly properties in structs
public struct ValueHolder3
{
    public ValueHolder3(int value)
    {
        this.Value = value;
    }

    public readonly int Value { get; init; }
}

// You can create readonly methods in structs
public struct ValueHolder4
{
    public ValueHolder4(int value)
    {
        this.Value = value;
    }

    public int Value { get; set; }

    public readonly int Multiply(int value)
    {
        // Value = 14; // Cannot change struct values in readonly methods
        return Value * value;
    }
}

// Struct doesn't support base type (struct)

// public struct BaseHolder
// {
//
// }
//
// public struct SubHolder : BaseHolder
// {
//
// }