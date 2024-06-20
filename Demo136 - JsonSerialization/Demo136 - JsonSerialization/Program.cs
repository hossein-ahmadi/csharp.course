// Demo136 - Json Serialization
// TOSINSO C# Mega Course

using System.Text.Json;

var person = new Person()
{
    Id = 1,
    Firstname = "Hossein",
    Lastname = "Ahmadi"
};

using var writeStream = File.Open("e:\\person.json", FileMode.Create);
JsonSerializer.Serialize(writeStream, person);
writeStream.Flush();
writeStream.Close();

using var readStream = File.Open("e:\\person.json", FileMode.Open);

var deserialized = JsonSerializer.Deserialize<Person>(readStream);

Console.ReadKey();

public class Person
{
    public int Id { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
}