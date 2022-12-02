/*
 *  Demo25 - Array types
 *  CSharp Master Class (TOSINSO)
 *  Hossein Ahmadi
 */

// Multi-Dimensional Arrays

int[,] twoDimensionalArray = new int[5,4];

for (int x = 0; x < 5; x++)
{
    for (int y = 0; y < 4; y++)
    {
        twoDimensionalArray[x, y] = y;
    }
}

for (int x = 0; x < 5; x++)
{
    for (int y = 0; y < 4; y++)
    {
        Console.Write($"{twoDimensionalArray[x, y]}\t");
    }

    Console.WriteLine();
}

int[,,] threeDimensionalArray = new int[8,6,2];

threeDimensionalArray[1,3,1] = 12;

// int[,,,] fourDimensionalArray = new int[7,5,3,1];

// Multi-Dimensional arrays initialization

int[,] twoDimensionalArrayB =
{
    { 1, 2, 3, 4, 5 },
    { 6, 7, 8, 9, 10 }
};

int[,,] threeDimensionalArrayB =
{
    {
        {1,2,3,6},
        {1,3,4,5}
    },
    {
        {7,8,6,3},
        {2,5,6,4}
    }
};

// Jagged Arrays

int[][] jaggedArray = new int[2][];

jaggedArray[0] = new int[12];
jaggedArray[0][0] = 5;

// Jagged Arrays Initialization

int[][] jaggedArrayB = new int[2][]
{
    new int[4] {2,4,5,6},
    new int[4] {1,3,4,7}
};