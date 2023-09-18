// Demo71 - Delegates
// TOSINSO C# Mega Course

namespace Delegates.App
{
    public delegate int CalculateDelegate(int number1, int number);

    public delegate T GenericCalculateDelegate<T>(T n1, T n2);

    public delegate void MultiCastDelegate();

    public static class Program
    {
        public static void Main()
        {
            // Basics

            CalculateDelegate md = Sum;

            Console.WriteLine(md(2, 6));

            Console.WriteLine(Calculate(5, 3, Multiply));

            // MultiCastDelegate

            MultiCastDelegate dl1, dl2, mld;

            dl1 = DisplayMessage1;

            dl2 = DisplayMessage2;

            mld = dl1 + dl2;

            mld();

            mld -= DisplayMessage2;

            mld();

            // Using Generic Delegates

            GenericCalculateDelegate<int> genericSum = Sum;

            Console.WriteLine(genericSum(8, 9));
        }

        private static int Calculate(int n1, int n2, CalculateDelegate logic)
        {
            return logic(n1, n2);
        }

        private static int Sum(int n1, int n2)
        {
            return n1 + n2;
        }

        private static int Multiply(int n1, int n2) => n1 * n2;

        // For Multi-Cast delegates

        public static void DisplayMessage1()
        {
            Console.WriteLine("Welcome to TOSINSO.COM");
        }

        public static void DisplayMessage2()
        {
            Console.WriteLine("This is C# Mega course");
        }
    }
}