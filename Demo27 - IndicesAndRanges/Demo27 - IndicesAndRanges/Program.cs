// Indices and Ranges

var array = new[] {1,2,3,4,5,6,7,8,90};

Console.WriteLine(array[^1]); // Get last element of array
Console.WriteLine(array[^4]);

Index idx = ^5;
Console.WriteLine(array[idx]);

Console.WriteLine("Ranges");
Console.WriteLine("---------------------");

var subArray = array[2..7];
foreach (var item in subArray)
{
    Console.WriteLine(item);
}

var subArray2 = array[3..^0];

Console.WriteLine("-------------------");
foreach (var item in subArray2)
{
    Console.WriteLine(item);
}

var subArray3 = array[3..];

Console.WriteLine("-------------------");
foreach (var item in subArray3)
{
    Console.WriteLine(item);
}

var subArray4 = array[..^3];

Console.WriteLine("-------------------");
foreach (var item in subArray4)
{
    Console.WriteLine(item);
}

Range rng = 3..5;

var subArray5 = array[rng];

Console.WriteLine("-------------------");
foreach (var item in subArray5)
{
    Console.WriteLine(item);
}