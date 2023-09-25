using Demo81___CustomExceptions.Exceptions;

namespace Demo81___CustomExceptions;

public class Calculator
{
    public static int Divide(int n1, int n2)
    {
        try
        {
            return n1 / n2;
        }
        catch(DivideByZeroException ex)
        {
            throw new CalculatorException("Divide by zero is not allowed", ex);
        }
    }
}