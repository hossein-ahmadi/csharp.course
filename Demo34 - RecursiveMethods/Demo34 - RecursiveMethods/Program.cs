// Recursive Methods

Console.WriteLine(Pow(3, 4));

Console.WriteLine(RecursivePow(3, 4));

int Pow(int number, int pow)
{
    int result = number;

    for (int counter = 0; counter < pow - 1; counter++)
    {
        result *= number;
    }

    return result;
}

int RecursivePow(int number, int pow)
{
    if (pow == 1)
    {
        return number;
    }

    return number * RecursivePow(number, pow - 1);
}