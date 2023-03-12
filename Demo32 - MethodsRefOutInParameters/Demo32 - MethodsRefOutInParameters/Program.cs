// Methods ref, out and in
int value = 8;

ChangeValue(ref value);

// ChangeValue(ref 12); => Uncomment to get error

Console.WriteLine(value);

void ChangeValue(ref int number)
{
    number = 12;
}

// out parameters

int reminder;
var result = Divide(15, 2, out reminder);

var result2 = Divide(15, 2, out int remain);

Console.WriteLine(result);
Console.WriteLine(reminder);
Console.WriteLine(remain);

Console.WriteLine(Divide(20, 2, out _));

//Console.WriteLine(Divide(15, 2));


int Divide(int number1, int number2, out int reminder)
{
    reminder = number1 % number2;
    return number1 / number2;
}

// in parameters

int Sum(in int number1, int number2)
{
    // number1 = 9; => Uncomment to get error
    return number1 + number2;
}