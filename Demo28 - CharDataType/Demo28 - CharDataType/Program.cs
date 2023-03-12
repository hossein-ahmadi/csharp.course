// Char data type

string str = "Welcome to TOSINSO.COM";

char chr = 'W';

Console.WriteLine(str[3]);

Console.WriteLine(char.IsNumber('5'));

// Password checker

Console.Write("Enter your password: ");
var password = Console.ReadLine();

bool lengthMoreThanEight = password.Length >= 8;

bool containsUppercase = false;
bool containsLowercase = false;
bool containsNumers = false;

foreach (var c in password)
{
    if (char.IsUpper(c))
    {
        containsUppercase = true;
    }
    else if (char.IsLower(c))
    {
        containsLowercase = true;
    }
    else if (char.IsNumber(c))
    {
        containsNumers = true;
    }
}

if (lengthMoreThanEight && containsUppercase && containsLowercase && containsNumers)
{
    Console.WriteLine("Your password is strong!");
}
else
{
    Console.WriteLine("Your password is weak!");
}

