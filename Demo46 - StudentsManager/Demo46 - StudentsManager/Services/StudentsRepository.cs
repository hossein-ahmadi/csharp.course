using System.Diagnostics.Metrics;
using Demo46___StudentsManager.Models;

namespace Demo46___StudentsManager.Services;

public class StudentsRepository
{
    private Models.Student?[] students = new Student?[20];

    public StudentsRepository()
    {
        students[0] = new Student()
        {
            Id = "001",
            Firstname = "Hossein",
            Lastname = "Ahmadi",
            NationalId = "1111111111",
            Age = 37
        };
        students[1] = new Student()
        {
            Id = "002",
            Firstname = "Mohammad",
            Lastname = "Nasiri",
            NationalId = "2222222222",
            Age = 37
        };
    }

    public bool Add(Models.Student student)
    {
        int nullIndex = 0;

        for (int index = 0; index < students.Length; index++)
        {
            if (students[index] == null)
            {
                nullIndex = index;
                break;
            }
        }

        students[nullIndex] = student;
        return true;
    }

    public int? FindIndex(string id)
    {
        for (int index = 0; index < students.Length; index++)
        {
            if (students[index] != null && students[index].Id == id)
            {
                return index;
            }
        }

        return null;
    }

    public Student[] GetAll()
    {
        return students;
    }

    public bool Delete(string id)
    {
        int indexToDelete = -1;

        for (int index = 0; index < students.Length; index++)
        {
            if (students[index] != null && students[index].Id == id)
            {
                indexToDelete = index;
            }
        }

        if (indexToDelete < 0)
            return false;

        students[indexToDelete] = null;

        return true;
    }

    public bool EditStudent(string id, string firstname, string lastname, string nationalId, byte age)
    {
        var student = GetStudent(id);
        if (student == null)
            return false;
        student.Firstname = firstname;
        student.Lastname = lastname;
        student.Age = age;
        student.NationalId = nationalId;
        return true;
    }

    public Student? GetStudent(int index)
    {
        return students[index];
    }

    public Student? GetStudent(string id)
    {
        var index = FindIndex(id);
        if(index.HasValue)
            return students[index.Value];
        return null;
    }

    public bool Add(string id, string firstname, string lastname, string nationalId, byte age)
    {
        return Add(new Student()
        {
            Id = id,
            Firstname = firstname,
            Lastname = lastname,
            NationalId = nationalId,
            Age = age
        });
    }

    public int Count
    {
        get
        {
            int count = 0;
            foreach (var student in students)
            {
                if (student != null)
                    count++;
            }
            return count;
        }
    }
}