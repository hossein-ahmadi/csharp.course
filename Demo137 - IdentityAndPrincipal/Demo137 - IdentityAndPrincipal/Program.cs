// Demo137 - Identity and Principal
// TOSINSO C# Mega Course

// Authentication

using System.Security.Principal;
using Demo137___IdentityAndPrincipal;

Dictionary<string, string> users = new()
{
    ["admin"] = "1234",
    ["guest"] = "12345",
};

Dictionary<string, string[]> roles = new()
{
    ["admin"] = new[] { "sysadmin" },
    ["guest"] = new[] { "displaymessage2" }
};

Console.Write("Username: ");
var username = Console.ReadLine();
Console.Write("Password: ");
var password = Console.ReadLine();

if (!users.ContainsKey(username) || users[username] != password)
{
    Console.WriteLine("Invalid username or password!");
    return;
}

var identity = new GenericIdentity(username);
var userRoles = roles.ContainsKey(username) ? roles[username] : new[] { "user" };
var principal = new GenericPrincipal(identity, userRoles);
System.Threading.Thread.CurrentPrincipal = principal;

var tools = new AppTools();

// Authorization

tools.DisplayWelcomeMessage();

tools.DisplayMessage2();