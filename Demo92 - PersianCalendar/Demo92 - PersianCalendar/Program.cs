// Demo92 - Persian Calendar
// TOSINSO C# Mega Course

using System.Globalization;

var persianCalendar = new PersianCalendar();

Console.WriteLine($"{persianCalendar.GetYear(DateTime.Now)}/{persianCalendar.GetMonth(DateTime.Now)}/{persianCalendar.GetDayOfMonth(DateTime.Now)}");

var datetime = new DateTime(1402, 8, 24, 5, 20, 30, persianCalendar);


Console.WriteLine(datetime);

Console.WriteLine(persianCalendar.IsLeapYear(1403));