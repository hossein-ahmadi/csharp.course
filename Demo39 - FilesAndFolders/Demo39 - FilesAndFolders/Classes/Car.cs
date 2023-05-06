namespace Demo39___FilesAndFolders.Classes;

public class Car
{
    public string Model { get; set; }
    public string Color { get; set; }

    public void DisplayInformation()
    {
        Console.WriteLine("Car information:");
        Console.WriteLine($"    Model: {Model}");
        Console.WriteLine($"    Color: {Color}");
    }
}