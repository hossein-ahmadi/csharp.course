namespace Demo33___MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayMessage("C# Master class!",3);
            DisplayMessage("Welcome TO TOSINSO!");
        }

        static void DisplayMessage(string message)
        {
            Console.WriteLine("Your message:" + message);
        }

        static void DisplayMessage(string message,int repeat)
        {
            for (int counter = 0; counter < repeat; counter++)
            {
                DisplayMessage(message);
            }
        }
    }
}