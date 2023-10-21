// Demo86 - LINQ (Language Integrated Query)
// TOSINSO C# Mega Course

var numbers = new[] { 2, 6, 3, 1, 9, 7, 8, 5, 4 };

Console.WriteLine("------------------- Filtered result output------------------");
var result = from n in numbers
    where n > 4
    select n;


var result2 = numbers.Where(n => n > 4);

foreach (var r in result2)
{
    Console.WriteLine(r);
}

Console.WriteLine("------------------- Ordered result output------------------");
var orderedResult = from n in numbers
    orderby n /* descending will sort list from bigger to lower */
    select n;

var orderedResult1 = numbers.OrderBy(n => n);

foreach (var i in orderedResult1)
{
    Console.WriteLine(i);
}

Console.WriteLine("------------------- Filtered ordered result output------------------");
var filteredOrderedResult = from n in numbers
    where n > 5
    orderby n descending
    select n;

var filteredOrderedResult2 = numbers.Where(n => n > 5).OrderByDescending(n => n);

foreach (var i in filteredOrderedResult)
{
    Console.WriteLine(i);
}


Console.WriteLine("------------------- Projected result output------------------");
var projectedResult = from n in numbers
    orderby n descending
    select $"Number is : {n}";

var projectedResult2 = numbers.OrderByDescending(n => n).Select(n => $"Number is : {n}");

foreach (var i in projectedResult2)
{
    Console.WriteLine(i);
}