// Demo146 - Sockets (Client Application)
// TOSINSO C# Mega Course

using System.Net;
using System.Net.Sockets;
using System.Text;

try
{
    var endpoint = IPEndPoint.Parse("127.0.0.1:3232");
    while (true)
    {
        Socket sender = new(endpoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
        sender.Connect(endpoint);

        Console.WriteLine($"Connected to {sender.RemoteEndPoint?.ToString()}");

        Console.Write("Message: ");
        var message = Console.ReadLine();

        sender.Send(Encoding.UTF8.GetBytes(message));
    }
}
catch(Exception exception)
{
    Console.WriteLine(exception.ToString());
}

Console.ReadKey();