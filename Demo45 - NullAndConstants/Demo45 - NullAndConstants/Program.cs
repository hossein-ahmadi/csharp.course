// Demo45 - NullAndConstants

using Demo45___NullAndConstants;

Person p = null;

// This line raise NullReferenceException
// Console.WriteLine(p.Name);

if (p != null)
{
    Console.WriteLine(p.Name);
}

// Reference nullable types
Person? p2 = null;

// int number = null;
int? number = null;
if (number != null)
{
    Console.WriteLine(number);
}
int? number2 = 12;

if (number2.HasValue)
{
    Console.WriteLine(number2);
}

// Constants
const int fixedNumber = 12; // Constants require initial value

// Cannot change value of constant variables. Uncomment to raise exception
// fixedNumber = 5;



