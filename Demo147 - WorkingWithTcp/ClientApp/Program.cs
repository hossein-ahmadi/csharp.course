// Demo147 - Tcp (Client App)
// TOSINSO C# Mega Course

using System.Net;
using System.Net.Sockets;
using System.Text;

try
{
    var endpoint = IPEndPoint.Parse("127.0.0.1:3232");
    while (true)
    {
        TcpClient client = new();
        client.Connect(endpoint);
        Console.WriteLine($"Connected to {endpoint.ToString()}");
        Console.Write("Message: ");
        var message = Console.ReadLine();
        var stream = client.GetStream();
        var buffer = Encoding.UTF8.GetBytes(message);
        stream.Write(buffer, 0, buffer.Length);
    }
}
catch (Exception exception)
{
    Console.WriteLine(exception);
}

Console.ReadKey();