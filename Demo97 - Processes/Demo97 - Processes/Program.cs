// Demo97 - Processes
// TOSINSO C# Mega Course

// Get All Processes

using System.Diagnostics;

var allProcesses = Process.GetProcesses();

foreach (var process in allProcesses)
{
    Console.WriteLine($"{process.Id}\t{process.ProcessName}");
}

// Get process by id

var vsProcess = Process.GetProcessById(24328);

Console.WriteLine("Display visual studio process info");
Console.WriteLine("-------------------------------------");
Console.WriteLine($"Id: {vsProcess.Id}");
Console.WriteLine($"Name: {vsProcess.ProcessName}");
foreach (ProcessThread thread in vsProcess.Threads)
{
    Console.Write($"\t{thread.Id}");
}

// var notepadProcess = new Process()
// {
//     StartInfo = new ProcessStartInfo("notepad","d:\\mytestfile.txt")
// };
//
// notepadProcess.Start();
//
// var calcProcess = new Process()
// {
//     StartInfo = new ProcessStartInfo("calc")
// };
// calcProcess.Start();

var edgeProcess = new Process()
{
    StartInfo = new ProcessStartInfo("msedge","tosinso.com")
    {
        UseShellExecute = true
    },
};

edgeProcess.Start();