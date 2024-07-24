// Demo147 - Tcp (Server App)
// TOSINSO C# Mega Course

using System.Net;
using System.Net.Sockets;
using System.Text;

try
{
    var endpoint = IPEndPoint.Parse("127.0.0.1:3232");
    TcpListener listener = new(endpoint); // => var socket = new Socket(endpoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
    listener.Start();
    while (true)
    {
        Console.WriteLine("Waiting for connection...");
        var client = listener.AcceptTcpClient();
        var stream = client.GetStream();
        var receivedBytes = new byte[1024];
        var allBytes = stream.Read(receivedBytes);
        var data = Encoding.UTF8.GetString(receivedBytes, 0, allBytes);
        Console.WriteLine($"Message received: {data}");
    }
}
catch (Exception exception)
{
    Console.WriteLine(exception);
}

Console.ReadKey();