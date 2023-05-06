// namespace Demos.Demo40_Namespaces.Tools
// {
        // public class Math
        // {
        //
        // }
// }

namespace Demos.Demo40_Namespaces.Tools;

public class Math
{
    public int Sum(int x, int y) => x + y;
    public int Divide(int x, int y) => x / y;
}

public class Messages
{
    public void Welcome(string name) => Console.WriteLine($"Welcome dear {name}");
}