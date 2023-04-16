// Class and Object

Car car = new Car();
car.Color = "Red";
car.Model = "BMW";

Console.WriteLine(car.Model);
car.Start();
car.Park();

class Car
{
    public string Model;
    public string Color;

    public void Start()
    {
        Console.WriteLine("Car started...");
    }

    public void Park()
    {
        Console.WriteLine("Car parked...");
    }
}