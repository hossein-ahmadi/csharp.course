// Demo78 - Pattern Matching
// TOSINSO C# Mega Course

// null checking

using Demo78___PatternMatching.Models;

int? number = 12;

if (number is int i)
{
    Console.WriteLine($"Number is {number}");
}

// discrete values

Console.Write("Enter shape: ");
var shape = Console.ReadLine();

Console.WriteLine(GetShapeMessage(shape));

// Relational patterns

Console.Write("Enter width of line: ");
var lineWidth = int.Parse(Console.ReadLine());

Console.WriteLine(GetLineWidthMessage(lineWidth));

// Property patterns
Shape rect = new Rectagle() { Width = 40, Height = 20 };

if (rect is Rectagle { Width: 40, Height: 20 })
{
    Console.WriteLine("Rectangle is medium size!");
}

if (rect is Rectagle { Width: > 10, Height: >= 40 })
{
    // Display a message to console
}

// var patterns
if (rect is Rectagle { Width: var w, Height: >= 20 } r && w % 2 == 0)
{
    // do something
}

// Positional Patterns
if (rect is Rectagle (20, 80))
{
    // do something
}

// Tuple patterns
Console.WriteLine(GetShapeDescription("Rectangle", 20, 40));

// ------------------------------------------------------
// Methods
// ------------------------------------------------------

// Used for discrete values
string GetShapeMessage(string shp) => shp switch
{
    "Circle" => "Shape is circle",
    "Rectangle" => "Shape is rectangle",
    _ => "Unknown shape"
};

// Used for relational pattern
string GetLineWidthMessage(int width) => width switch
{
    <0 => "Invalid width",
    (>0) and (<=20) => "Line is too short!",
    (>20) and (<=40) => "Line is medium",
    (>40) => "Line is too long"
};

// Used for tuple patterns
string GetShapeDescription(string shape, int width, int height)
{
    return (shape, width, height) switch
    {
        ("Rectangle", 20, 40) => "Shape is rectangle and size is medium",
        ("Rectangle", 100, 80) => "Shape is rectangle and size is big",
        (_, _, _) => "Shape is unknown"
    };
}