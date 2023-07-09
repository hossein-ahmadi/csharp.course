// Demo52
// Polymorphism

using Demo52___Polymorphism.Models;

var persianHuman = new PersianHuman()
{
    Name = "Hossein"
};

var englishHuman = new EnglishHuman()
{
    Name = "Jack"
};

Console.WriteLine(persianHuman.ToString());
persianHuman.Speak();
Console.WriteLine(persianHuman.Description);

englishHuman.Speak();
Console.WriteLine(englishHuman.Description);