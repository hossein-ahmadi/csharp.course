// Complementary (local refs, ref return, expression bodies)

// local refs

var numbers = new[] {1,2,3,4,5};

ref var number = ref numbers[2];

number = 12;

Console.WriteLine(numbers[2]);

// ref return

var names = new[] { "Hossein", "Mohammad", "Alireza", "Mehdi" };

ref var name = ref Find(names, "Alireza");

Console.WriteLine(name);

name = "Ali";

ref string Find(string[] names, string key)
{
    for (int index = 0; index < names.Length; index++)
    {
        if (names[index] == key)
            return ref names[index];
    }

    throw new InvalidOperationException();
}

// Expression bodies

Console.WriteLine(Sum(12, 2));

int Sum(int a, int b) => a + b;

// int Sum(int a, int b)
// {
//     return a + b;
// }