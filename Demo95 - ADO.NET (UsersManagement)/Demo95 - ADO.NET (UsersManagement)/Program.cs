// Demo95 - ADO.NET (Users Management)
// TOSINSO C# Mega Course

using Demo95___ADO.NET__UsersManagement_.Repositories;

var usersRepository = new UsersRepository();
var usersCount = usersRepository.Count;

if (usersCount == 0)
{
    Console.WriteLine("Create user");
    Console.WriteLine("---------------------");
    Console.Write("Username: ");
    var newUsername = Console.ReadLine();
    Console.Write("Password: ");
    var newPassword = Console.ReadLine();
    var result = usersRepository.CreateUser(newUsername, newPassword);
}

while (true)
{
    Console.Clear();
    Console.Write("Username: ");
    var username = Console.ReadLine();
    Console.Write("Password: ");
    var password = Console.ReadLine();

    if (usersRepository.ValidateUser(username, password))
    {
        Console.WriteLine("Welcome to Accounting Application");
        break;
    }
    else
    {
        Console.WriteLine("Invalid username or password! Press any key to continue");
        Console.ReadKey();
    }
}

while (true)
{
    Console.Clear();
    Console.WriteLine("Users Management");
    Console.WriteLine("---------------------------------");
    Console.WriteLine("1. Add user");
    Console.WriteLine("2. Change password");
    Console.WriteLine("3. Delete user");
    Console.WriteLine("4. List users");
    Console.WriteLine("5. Exit");

    Console.WriteLine();
    Console.Write("Select an option: ");
    var option = Console.ReadLine();

    if (int.TryParse(option, out var parsedOption))
    {
        switch (parsedOption)
        {
            case 1:
                Console.Clear();
                Console.Write("Username: ");
                var newUsername = Console.ReadLine();
                if (usersRepository.ExistsUser(newUsername))
                {
                    Console.WriteLine("Username exists in database. Press any key to continue...");
                    Console.ReadKey();
                }
                else
                {
                    Console.Write("Password: ");
                    var newPassword =  Console.ReadLine();
                    if (usersRepository.CreateUser(newUsername, newPassword))
                    {
                        Console.WriteLine($"User {newUsername} created");
                        Console.ReadKey();
                    }
                }
                break;
            case 2:
                Console.Clear();
                Console.Write("Username: ");
                var username = Console.ReadLine();
                if (!usersRepository.ExistsUser(username))
                {
                    Console.WriteLine("Username not exists in database. Press any key to continue...");
                    Console.ReadKey();
                }
                else
                {
                    Console.Write("new password: ");
                    var newPassword = Console.ReadLine();
                    if (usersRepository.ChangePassword(username, newPassword))
                    {
                        Console.WriteLine($"User {username} password changed!");
                        Console.ReadKey();
                    }
                }
                break;
            case 4:
                var users = usersRepository.GetAll();
                Console.Clear();
                foreach (var user in users)
                {
                    Console.WriteLine($"{user.Id}\t{user.Username}\t{user.Password}\t{user.RegisterDate}");
                }

                Console.ReadKey();
                break;
            case 5:
                return;
            default:
                break;
        }
    }
}

Console.ReadKey();