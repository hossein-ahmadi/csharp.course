// Demo146 - Sockets (Server Application)
// TOSINSO C# Mega Course


using System.Net;
using System.Net.Sockets;
using System.Text;

var endpoint = IPEndPoint.Parse("127.0.0.1:3232");

Socket listener = new(endpoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

try
{
    listener.Bind(endpoint);
    listener.Listen();

    while (true)
    {
        Console.WriteLine("Waiting for connection...");
        var clientSocket = listener.Accept();
        var receivedBytes = new byte[1024];
        var numBytes = clientSocket.Receive(receivedBytes);

        var data = Encoding.UTF8.GetString(receivedBytes, 0, numBytes);

        Console.WriteLine($"Message received: {data}");
    }
}
catch (Exception e)
{
    Console.WriteLine(e);
}

Console.ReadKey();