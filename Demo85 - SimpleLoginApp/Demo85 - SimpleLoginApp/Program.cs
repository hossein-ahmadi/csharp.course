// Demo85 - Simple Login App
// TOSINSO C# Mega Course

var users = new Dictionary<string,string>()
{
    ["hossein"] = "123",
    ["mohammad"] = "a123a",
    ["mehdi"] = "ab1ab"
};

int invalidAttempts = 3;

while (true)
{
    Console.Clear();
    Console.WriteLine($"Remain login attempts: {invalidAttempts}");
    Console.Write("Username: ");
    var username = Console.ReadLine();
    Console.Write("Password: ");
    var password = Console.ReadLine();

    if (users.ContainsKey(username) && users[username] == password)
    {
        Console.WriteLine("Welcome to simple login app!");
        Console.ReadKey();
        break;
    }
    else
    {
        Console.WriteLine("Invalid username or password!");
        invalidAttempts--;
        if (invalidAttempts == 0)
        {
            Console.WriteLine("There's no login attempts!");
            break;
        }
        Console.ReadKey();
        continue;
    }
}