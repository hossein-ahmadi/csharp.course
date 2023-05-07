namespace Demo41.Tools;

public class Math
{
    public int Sum(int x, int y) => x + y;

    public decimal Divide(decimal x, decimal y)
    {
        var pc = new PrivateClass();

        if (y == 0)
        {
            throw new System.DivideByZeroException();
        }

        return x / y;
    }

    private decimal Subtract(decimal x, decimal y) => x - y;

    internal decimal Multiply(decimal x, decimal y) => x * y;
}