namespace Demo46___StudentsManager.Models;

public class Student
{
    public string Id { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public byte Age { get; set; }
    public string NationalId { get; set; }

    public byte[] Marks { get; set; } = new byte[10];
}