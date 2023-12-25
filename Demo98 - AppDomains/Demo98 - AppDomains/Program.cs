// Demo98 - AppDomains
// TOSINSO C# Mega Course

var currentDomain = AppDomain.CurrentDomain;

Console.WriteLine($"Id: {currentDomain.Id}");
Console.WriteLine($"Name: {currentDomain.FriendlyName}");
Console.WriteLine($"Path: {currentDomain.BaseDirectory}");

foreach (var assembly in currentDomain.GetAssemblies())
{
    Console.WriteLine($"assembly: {assembly.FullName}");
}