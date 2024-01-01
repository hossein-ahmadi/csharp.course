// Demo102 - Timer
// TOSINSO C# Mega Course

Timer timer = new Timer(state =>
{
    Console.WriteLine(DateTime.Now.ToString("hh:mm:ss"));
},null,0,2000);

Console.WriteLine("Press any key to exit!");
Console.ReadKey();