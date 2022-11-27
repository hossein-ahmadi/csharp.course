// If Statement

Console.Write("Username: ");
var username = Console.ReadLine();
Console.Write("Password: ");
var password = Console.ReadLine();

if (username == "tosinso" && password == "123")
{
    Console.WriteLine("Welcome to my application");
}
else if (username == "hossein" && password == "789")
{
    Console.WriteLine("Welcome Hossein...");
}
else if (username == "ali" && password == "741")
{
    Console.WriteLine("Welcome Ali...");
}
else
{
    Console.WriteLine("Sorry! Username or password is invalid...");
}