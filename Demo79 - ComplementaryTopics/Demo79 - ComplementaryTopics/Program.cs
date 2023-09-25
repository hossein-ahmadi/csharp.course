// Demo79 - Complementary topics
// TOSINSO C# Mega Course

// Static usings
using static System.Console;

// Using aliases
using GCL = System.Collections.Generic;

var lst = new GCL.List<string>();

Student std = new Student();

WriteLine("Welcome to C# Mega course");

// Local functions
string NormalizeText(string input)
{
    return ToUpper(input.Trim());

    // Local function
    string ToUpper(string i1)
    {
        return i1.ToUpper();
    }
}