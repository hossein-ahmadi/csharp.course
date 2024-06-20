// Demo134 - Streams
// TOSINSO C# Mega Course

// write to files

using System.Text;

using var writeFileStream = new FileStream("e:\\myfile.txt", FileMode.OpenOrCreate);
{
    // var textBytes = System.Text.Encoding.UTF8.GetBytes("Welcome to TOSINSO.COM");
    //
    // writeFileStream.Write(textBytes, 0, textBytes.Length);
    using var streamWriter = new StreamWriter(writeFileStream, Encoding.UTF8);
    {
        streamWriter.WriteLine("TOSINSO.COM C# Mega Course");
    }
}


// read from files
using var readFileStream = new FileStream("e:\\myfile.txt",FileMode.OpenOrCreate);
{
    // var buffer = new byte[readFileStream.Length];
    //
    // readFileStream.Read(buffer, 0, (int)readFileStream.Length);
    //
    // Console.WriteLine(System.Text.Encoding.UTF8.GetString(buffer));

    using var streamReader = new StreamReader(readFileStream);
    {
        Console.WriteLine(streamReader.ReadToEnd());
    }
}

Console.ReadKey();