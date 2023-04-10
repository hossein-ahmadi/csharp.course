// Enum types

Seasons s = Seasons.Autumn;

Seasons s2 = (Seasons)40;

Console.WriteLine(s);

Console.WriteLine((int)s);

Console.WriteLine(s2);

enum Seasons : byte
{
    Spring = 10,
    Summer = 20,
    Autumn = 30,
    Winter = 40
}

enum Sex : byte
{
    Male = 1,
    Female = 2
}