namespace Demo55___CalcWithOOP.MathOperators;

public class AddOperator : Base.MathOperation
{
    public AddOperator(decimal number1, decimal number2) : base(number1, number2)
    {
    }

    public override decimal Operate()
    {
        return Number1 + Number2;
    }
}