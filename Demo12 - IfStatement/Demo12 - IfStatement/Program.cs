/*
 *  Demo12 - If statement
 *  CSharp Master Class (TOSINSO)
 *  Hossein Ahmadi
 */
 
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
else // braces can be removed for single line statements
    Console.WriteLine("Sorry! Username or password is invalid...");