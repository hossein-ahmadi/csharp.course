/*
 *  Demo21 - While loops
 *  CSharp Master Class (TOSINSO)
 *  Hossein Ahmadi
 */

int counter = 1;

while (counter <= 10)
{
    Console.WriteLine(counter);
    counter++;
}

// for (int counter = 1; counter <= 10; counter++)
// {
//     Console.WriteLine(counter);
// }

// infinite while loop
Console.WriteLine("Infinite loop");
int number = 1;

while (true)
{
    if (number > 10)
    {
        break;
    }
    Console.WriteLine(number);
    number++;
}

// do while loop
Console.WriteLine("Do while loop");
int counter2 = 11;

do
{
    Console.WriteLine(counter2);
} while(counter2 <= 10);