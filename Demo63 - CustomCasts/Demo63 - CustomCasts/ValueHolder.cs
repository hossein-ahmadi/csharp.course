namespace Demo63___CustomCasts;

public class ValueHolder
{
    public ValueHolder(int value)
    {
        Value = value;
    }

    public int Value { get; set; }

    public static implicit operator int(ValueHolder holder)
    {
        return holder.Value;
    }

    public static implicit operator string(ValueHolder holder)
    {
        return holder.Value.ToString();
    }

    public static explicit operator ValueHolder(int value)
    {
        return new ValueHolder(value);
    }
}