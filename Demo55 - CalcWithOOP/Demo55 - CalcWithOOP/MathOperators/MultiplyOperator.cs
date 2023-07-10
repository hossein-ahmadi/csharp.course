using Demo55___CalcWithOOP.Base;

namespace Demo55___CalcWithOOP.MathOperators;

public class MultiplyOperator : MathOperation
{
    public MultiplyOperator(decimal number1, decimal number2) : base(number1, number2)
    {
    }

    public override decimal Operate()
    {
        return Number1 * Number2;
    }
}