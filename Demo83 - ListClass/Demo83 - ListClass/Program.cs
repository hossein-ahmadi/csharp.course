// Demo83 - Collections (List class)
// TOSINSO C# Mega Course

List<int> numbers = new List<int>()
{
    2, 4, 8, 1, 2
};

numbers.Add(2);
numbers.Add(3);
numbers.Add(8);

numbers.Remove(2);

numbers.RemoveAll(i => i == 2);

numbers.RemoveAt(0);

if (numbers.Contains(8))
{
    Console.WriteLine("List contains 8");
}

Console.WriteLine(numbers.Count);

var strNumbers = numbers.ConvertAll(i => i.ToString());

if (numbers.Exists(i => i > 2))
{
    Console.WriteLine("list contains numbers greater that 2");
}

foreach (var i in numbers.FindAll(i=>i>2))
{
    Console.WriteLine(i);
}

numbers.ForEach(i =>
{
    Console.WriteLine($"{i} exists in numbers");
});

numbers.Insert(1, 9);

numbers.InsertRange(1, new[] { 10, 11, 12 });

numbers.Sort();

if (numbers.TrueForAll(i => i < 100))
{
    Console.WriteLine("All numbers in list are lower than 100");
}

Console.ReadKey();