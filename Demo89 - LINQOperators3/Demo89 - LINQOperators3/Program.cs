// Demo89 - LINQ Operators Part 3
// TOSINSO C# Mega Course

var numbers1 = new[] { 2, 6, 9, 1, 10, 5, 21, 2, 8, 12, 1, 4, 7, 11, 10, 1, 8, 9, 3 };
var numbers2 = new[] { 11, 21, 13, 15, 12, 18, 16, 17 };

var firstElement = numbers1.OrderByDescending(c => c).First();
Console.WriteLine(numbers1.Where(c => c > 40).FirstOrDefault());
Console.WriteLine(firstElement);


Console.WriteLine(numbers1.Last());

Console.WriteLine(numbers1.Average());

Console.WriteLine(numbers1.Count());
Console.WriteLine(numbers1.LongCount());
Console.WriteLine("Distinct list---------------------");
foreach (var i in numbers1.Distinct())
{
    Console.WriteLine(i);
}

Console.WriteLine("union list---------------------");
foreach (var i in numbers1.Union(numbers2))
{
    Console.WriteLine(i);
}
Console.WriteLine("take operator---------------------");
foreach (var i in numbers1.Take(5))
{
    Console.WriteLine(i);
}

Console.WriteLine("skip operator---------------------");
foreach (var i in numbers1.Skip(5))
{
    Console.WriteLine(i);
}

Console.WriteLine("take and skip operator---------------------");
foreach (var i in numbers1.Skip(5).Take(3))
{
    Console.WriteLine(i);
}


Console.WriteLine("any operator ---------------------");
Console.WriteLine(numbers1.Any(n => n < 10));
Console.WriteLine(numbers1.Any(n => n > 30));

Console.WriteLine("all operator ---------------------");
Console.WriteLine(numbers1.All(n=>n> 10));
Console.WriteLine(numbers2.All(n => n > 10));

// ToDictionary operator
Console.WriteLine("ToDictionary operator ---------------------");
var dictionary = numbers1.Distinct().ToDictionary(n=>n, n=>$"Number is {n}");
foreach (var item in dictionary)
{
    Console.WriteLine(item.Key + ": " + item.Value);
}

// Single, SingleOrDefault, Intersect, TakeWhile, SkipWhile