namespace Demo72___ActionAndFuncDelegates;

public static class Logics
{
    public static void DisplayMessage(string message)
    {
        Console.WriteLine(message);
    }

    public static void RepeatMessage(string message, int repeatCount)
    {
        for (int i = 0; i < repeatCount; i++)
        {
            Console.WriteLine(message);
        }
    }

    public static int Sum(int n1, int n2) => n1 + n2;


    public static decimal Multiply(decimal n1, decimal n2) => n1 * n2;
}