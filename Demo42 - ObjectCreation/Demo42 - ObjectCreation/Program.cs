// Demo42 - Object Creation

using Demo42___ObjectCreation;

// Assign properties values using object initialization
var bmw = new Car()
{
    Model = "X6",           // bmw.Model = "X6";
    Color = Color.Blue      // bmw.Color = Color.Blue;
};

// Target-Typed new expression
Car benz = new()
{
    Model = "Maybach",
    ProductionYear = 2022
};
benz.Color = Color.Blue;

// Cannot assign value to init only properties (uncomment to raise error)
// benz.ProductionYear = 2022;


