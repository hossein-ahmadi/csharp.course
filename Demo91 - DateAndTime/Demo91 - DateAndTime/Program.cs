// Demo91 - Date and Time
// TOSINSO C# Mega Course

using Demo91___DateAndTime.Models;

Console.WriteLine(DateTime.Now);
Console.WriteLine(DateTime.UtcNow);

Console.WriteLine(DateTime.Now.Day);
Console.WriteLine(DateTime.Now.Hour);
Console.WriteLine(DateTime.Now.Year);

Console.WriteLine(DateTime.Now.AddDays(10));
Console.WriteLine(DateTime.Now.AddYears(-2));
Console.WriteLine(DateTime.Now.AddMinutes(30));

var customDate = new DateTime(2021,10,12,18,0,0);

Console.WriteLine(customDate);


var order = new Order()
{
    Id = 1,
    Title = "Order 1",
    Date = DateTime.Now
};

Console.WriteLine(DateTime.Now.ToString("yyyy - MMMM - dd hh:mm:ss"));