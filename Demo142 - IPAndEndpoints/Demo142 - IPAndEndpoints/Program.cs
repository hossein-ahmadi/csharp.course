// Demo142 - IP Addresses and EndPoints
// TOSINSO C# Mega Course

using System.Net;

IPAddress tosinsoIPAddress = new IPAddress(new byte[] {87,236,209,251});
IPAddress googleIPAddress = IPAddress.Parse("142.250.74.78");

IPEndPoint tosinsoEndPoint = new IPEndPoint(tosinsoIPAddress, 50);
IPEndPoint googleEndpoint = IPEndPoint.Parse("142.250.74.78:443");

Console.WriteLine(tosinsoIPAddress);
Console.WriteLine(googleIPAddress);
Console.WriteLine(tosinsoEndPoint);
Console.WriteLine(googleEndpoint);

var addresses = await Dns.GetHostAddressesAsync("tosinso.com");

foreach (var ipAddress in addresses)
{
    Console.WriteLine(ipAddress);
}

Console.ReadKey();