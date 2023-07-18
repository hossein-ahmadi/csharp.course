namespace Demo62___OperatorOverloading;

public class ValueHolder
{
    public ValueHolder(int value)
    {
        Value = value;
    }

    public int Value { get; set; }

    public static ValueHolder operator +(ValueHolder op1, ValueHolder op2)
    {
        return new ValueHolder(op1.Value + op2.Value );
    }

    public static ValueHolder operator *(ValueHolder op1, ValueHolder op2)
    {
        return new ValueHolder(op1.Value * op2.Value);
    }

    public static ValueHolder operator -(ValueHolder op)
    {
        return new ValueHolder(op.Value * -1);
    }
}