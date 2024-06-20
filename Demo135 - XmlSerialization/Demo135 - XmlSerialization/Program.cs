// Demo135 - XmlSerialization
// TOSINSO C# Mega Course

using System.Xml.Serialization;

var person = new Person()
{
    Id = 1,
    Firstname = "Hossein",
    Lastname = "Ahmadi"
};

using var streamWriter = File.Open("e:\\person.xml", FileMode.Create);
var serializer = new XmlSerializer(typeof(Person));
serializer.Serialize(streamWriter, person);
streamWriter.Flush();
streamWriter.Close();

using var streamReader = File.Open("e:\\person.xml", FileMode.Open);
var deserializer = new XmlSerializer(typeof(Person));
var deserializedPerson = deserializer.Deserialize(streamReader);

Console.ReadKey();


public class Person
{
    [XmlAttribute]
    public int Id { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
}
