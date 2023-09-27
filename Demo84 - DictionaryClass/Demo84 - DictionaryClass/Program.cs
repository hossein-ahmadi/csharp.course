// Demo84 - Dictionary Class
// TOSINSO C# Mega Course

using Demo84___DictionaryClass.Models;

Dictionary<int, string> intStrings1 = new Dictionary<int, string>();

var studentsDic1 = new Dictionary<int, Student>
{
    {1, new Student(){Id = 1, Firstname = "Mohammad", Lastname = "Nasiri"}},
    {2, new Student(){Id = 1, Firstname = "Hossein", Lastname = "Ahmadi"}}
};

var studentsDic2 = new Dictionary<int, Student>()
{
    [1] = new Student() { Id = 1, Firstname = "Mohammad", Lastname = "Nasiri" },
    [2] = new Student() { Id = 1, Firstname = "Hossein", Lastname = "Ahmadi" },
};

intStrings1.Add(1, "Hossein Ahmadi");
intStrings1.Add(2, "Mohammad Nasiri");
intStrings1.Add(3, "Mehdi Adeli");

// intStrings1.Add(1, "Alireza Fazeli"); cannot add same keys in dictionary

Console.WriteLine(intStrings1[2]);

intStrings1.Remove(1);

if (intStrings1.ContainsKey(2))
{
    Console.WriteLine($"Value for key 2 is {intStrings1[2]}");
}

try
{
    Console.WriteLine(intStrings1[4]);
}
catch (KeyNotFoundException ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadKey();