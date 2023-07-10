﻿using Demo55___CalcWithOOP.Base;

namespace Demo55___CalcWithOOP.MathOperators;

public class DivideOperator : MathOperation
{
    public DivideOperator(decimal number1, decimal number2) : base(number1, number2)
    {
    }

    public override decimal Operate()
    {
        return Number1 / Number2;
    }

    public override bool Validate()
    {
        if(Number2 == 0)
            return false;
        return true;
    }
}