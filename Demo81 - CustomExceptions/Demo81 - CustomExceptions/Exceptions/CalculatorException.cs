namespace Demo81___CustomExceptions.Exceptions;

public class CalculatorException : ApplicationException
{
    public CalculatorException(string message, Exception ex) : base(message,ex)
    {

    }
}