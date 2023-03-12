// Method params

Console.WriteLine(Sum(4,5,6));


int Sum(params int[] numbers)
{
    int result = 0;

    foreach (var number in numbers)
    {
        result += number;
    }

    return result;
}

Console.WriteLine(Calculate("sum", 2, 3, 4));
Console.WriteLine(Calculate("average", 2, 3, 4));

// decimal Calculate(params int[] numbers, string type) => invalid usage of params

decimal Calculate(string type, params int[] numbers)
{
    decimal sum = 0m;

    foreach (var number in numbers)
    {
        sum += number;
    }

    switch (type)
    {
        case "sum":
        case "SUM":
            return sum;
        case "average":
        case "AVERAGE":
            return sum / numbers.Length;
        default:
            return 0;
    }
}