/*
 *  Demo26 - Foreach statement
 *  CSharp Master Class (TOSINSO)
 *  Hossein Ahmadi
 */

int[] numbers = new[] {1,2,3,4,5,6,7,8,9,10};

Console.WriteLine("Iterate with for statement");
for (var index = 0; index < numbers.Length; index++)
{
    Console.WriteLine(numbers[index]);
}

Console.WriteLine("Iterate with foreach statement");
foreach (var number in numbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("Iterate jagged array with foreach statement");
int[][] jaggedArray =
{
    new [] {2,3,4,5,6},
    new [] {4,5,7,2,1}
};

foreach (var arr in jaggedArray)
{
    foreach (var item in arr)
    {
        Console.Write($"{item}\t");
    }

    Console.WriteLine();
}