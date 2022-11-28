/*
 *  Demo07 - Arithmetic operators
 *  CSharp Master Class (TOSINSO)
 *  Hossein Ahmadi
 */

// Math binary operators
Console.WriteLine("Math operators");
Console.WriteLine("----------------------------");
Console.WriteLine(2 + 2);

int number1 = 12;
int number2 = 20;
int number3 = 0;

int sum = number1 + number2;
int sum1 = number1 + 25;
int substract = number2 - number1;
int multiply = number1 * number2;
int divide = number1 / number2;
int divideReminder = number2 % number1;

decimal decimalNumber1 = 12m;
decimal decimalNumber2 = 20m;
decimal decimalDivide = decimalNumber1 / decimalNumber2;

// int divideByZero = number1 / number3; divide by zero is not allowed

Console.WriteLine(sum);
Console.WriteLine(sum1);
Console.WriteLine(substract);
Console.WriteLine(multiply);
Console.WriteLine(divide);
Console.WriteLine(decimalDivide);
Console.WriteLine(divideReminder);
Console.WriteLine();
Console.WriteLine("Postfix and Prefix ++ and -- operators");
Console.WriteLine("-------------------------");
Console.WriteLine(3 + 1);
// postfix operators
Console.WriteLine(number1++);
Console.WriteLine(number1);
Console.WriteLine(number1--);
Console.WriteLine(number1);
// prefix operatorts
Console.WriteLine(++number1);
Console.WriteLine(number1);
Console.WriteLine(--number1);
Console.WriteLine(number1);

Console.WriteLine();
Console.WriteLine("Unary - and + operators");
Console.WriteLine("----------------------------");
Console.WriteLine(number1);
Console.WriteLine(-number1);

int number4 = -5;

Console.WriteLine(number4);
Console.WriteLine(+number4);
Console.WriteLine(-number4);

Console.WriteLine();
Console.WriteLine("Compound assignment operators");
Console.WriteLine("----------------------------------");

int number5 = 15;

number5 += 3;
number5 *= 2;
number5 -= 5;

Console.WriteLine(number5);

Console.WriteLine();
Console.WriteLine("Operators precedence");
Console.WriteLine("------------------------------");

int result1 = (5 - 2) * (3 + 1);
    // 3 * 4
    // 12

// Operator precedece
    // 1. postfix ++ and --
    // 2. prefix ++ and --
    // 3. multiply and divide
    // 4. add and substract

Console.WriteLine(result1);
