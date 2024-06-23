// Demo138 - Windows Identity
// TOSINSO C# Mega Course

using System.Security.Principal;

var windowsIdentity = WindowsIdentity.GetCurrent();

var windowsPrincipal = new WindowsPrincipal(windowsIdentity);

Console.WriteLine($"Name: {windowsIdentity.Name}");
Console.WriteLine("-------------------------------------");
foreach (var group in windowsIdentity.Groups)
{
    Console.WriteLine($"{group.Translate(typeof(NTAccount))}");
}
Console.WriteLine($"User is administrator: {windowsPrincipal.IsInRole("BUILTIN\\Administrators")}");