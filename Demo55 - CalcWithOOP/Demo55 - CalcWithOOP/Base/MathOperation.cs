namespace Demo55___CalcWithOOP.Base;

public abstract class MathOperation
{
    protected MathOperation(decimal number1, decimal number2)
    {
        Number1 = number1;
        Number2 = number2;
    }

    public decimal Number1 { get; set; }
    public decimal Number2 { get; set; }

    public abstract decimal Operate();

    public virtual bool Validate()
    {
        return true;
    }
}