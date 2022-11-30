/*
 *  Demo18 - Loops (for statement)
 *  CSharp Master Class (TOSINSO)
 *  Hossein Ahmadi
 */

for (int counter = 1; counter <= 10; counter++)
{
    Console.WriteLine(counter);
}

// Output even numbers between 1 and 100

Console.WriteLine("-- even numbers between 1 and 100 (First method)");
for (int counter = 1; counter <= 100; counter++)
{
    if (counter % 2 != 0)
    {
        continue;
    }
    Console.WriteLine(counter);
}

Console.WriteLine("-- even numbers between 1 and 100 (Second method)");
for (int counter = 2; counter <= 100; counter += 2)
{
    Console.WriteLine(counter);
}

// break statement
Console.WriteLine("-- Break statement");
for (int counter = 1; counter <= 10; counter++)
{
    if (counter > 5)
    {
        break;
    }
    Console.WriteLine(counter);
}