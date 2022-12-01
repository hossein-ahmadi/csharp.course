/*
 *  Demo24 - Arrays
 *  CSharp Master Class (TOSINSO)
 *  Hossein Ahmadi
 */

// Declaration

int[] numbers = new int[10]; // var numbers = new int[10];

// Assign and get values from arrays

numbers[0] = 1;
Console.WriteLine(numbers[0]);

// All ways to declare arrays in c#

int[] numbers2 = new int[10];

// Declare arrays with initialization
int[] numbers3 = new int[] {5,8,9,3,4,1};
int[] numbers4 = new[] {5,8,9,3};
int[] numbers5 = {4,5,6,7,8};

int indexes = 12;
int[] numbers6 = new int[indexes];

// get length from input
Console.Write("Enter array length: ");
var arrayLength = int.Parse(Console.ReadLine());
int[] numbers7 = new int[arrayLength];

// Get length of array
Console.WriteLine($"Length of array: {numbers7.Length}");