// Demo45
// Students manager
// C# and .NET Course

using Demo46___StudentsManager.Models;
using Demo46___StudentsManager.Services;
StudentsRepository repo = new StudentsRepository();
while (true)
{
    Console.Clear();
    Console.WriteLine("Students manager");
    Console.WriteLine($"Total students: {repo.Count}");
    Console.WriteLine("-------------------------");
    Console.WriteLine("1. Add");
    Console.WriteLine("2. Edit");
    Console.WriteLine("3. Delete");
    Console.WriteLine("4. Find");
    Console.WriteLine("5. List");
    Console.WriteLine("6. Exit");

    Console.WriteLine();
    Console.Write("Select menu item: ");
    var selectedItem = Console.ReadLine();

    switch (selectedItem)
    {
        case "1":
        {
            Console.Clear();
            Console.WriteLine("Create new student");
            Console.WriteLine("--------------------");
            Console.Write("Id: ");
            var id = Console.ReadLine();
            if (repo.FindIndex(id).HasValue)
            {
                Console.WriteLine($"Student with id {id} already exists.");
                Console.ReadKey();
                continue;
            }

            if (GetValues(out var firstname, out var lastname, out var nationalId, out var age))
                continue;

            repo.Add(id, firstname, lastname, nationalId, age);
            break;
        }
        case "2":
        {
            Console.Clear();
            Console.WriteLine("Edit student");
            Console.WriteLine("--------------------------");
            var student = GetStudent(repo, out var id);
            if (student == null)
            {
                Console.WriteLine("Student with id {id} not found!");
                Console.ReadKey();
                continue;
            }
            Console.WriteLine("Current student values:");
            Console.WriteLine($"Firstname: {student.Firstname} | Lastname: {student.Lastname} | NationalId: {student.NationalId} | Age: {student.Age}");
            if (GetValues(out var firstname, out var lastname, out var nationalId, out var age))
                continue;

            if (repo.EditStudent(id, firstname, lastname, nationalId, age))
            {
                Console.WriteLine("Student updated!");
            }
            else 
            {
                Console.WriteLine("Cannot edit student!");
            }

            Console.ReadKey();
            break;
        }
        case "3":
        {
            Console.Clear();
            Console.Write("Delete student");
            Console.WriteLine("--------------------");
            Console.Write("Id: ");
            var id = Console.ReadLine();
            if (repo.Delete(id))
            {
                Console.WriteLine("Student deleted...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"Student with id {id} not exists!");
                Console.ReadLine();
            }
            break;
        }
        case "4":
        {
            Console.Clear();
            Console.WriteLine("Find student");
            Console.WriteLine("--------------------------");
            var student = GetStudent(repo, out var id);
            if (student == null)
            {
                Console.WriteLine($"Cannot find student with id {id}");
            }
            else
            {
                Console.WriteLine($"Firstname: {student.Firstname} | Lastname: {student.Lastname} | NationalId: {student.NationalId} | Age: {student.Age}");
            }

            Console.ReadKey();
            break;
        }
        case "5":
            Console.Clear();
            Console.WriteLine("All students");
            Console.WriteLine("--------------------------");
            var all = repo.GetAll();
            for (var index = 0; index < all.Length; index++)
            {
                var student = all[index];
                if (student != null)
                    Console.WriteLine(
                        $"{index + 1}. Firstname: {student.Firstname} | Lastname: {student.Lastname} | NationalId: {student.NationalId} | Age: {student.Age}");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to back to menu...");
            Console.ReadKey();
            break;
        case "6":
            return;
        default:
            Console.Write("Invalid menu item! Press any key to continue...");
            Console.ReadKey();
            break;
    }
}

bool GetValues(out string? firstname, out string? lastname, out string? nationalId, out byte age)
{
    age = 0;
    Console.Write("Firstname: ");
    firstname = Console.ReadLine();
    Console.Write("Lastname: ");
    lastname = Console.ReadLine();
    Console.Write("NationalId: ");
    nationalId = Console.ReadLine();
    if (string.IsNullOrEmpty(nationalId) || nationalId.Length != 10)
    {
        Console.WriteLine("Invalid national id format!");
        Console.ReadKey();
        return true;
    }

    Console.Write("Age: ");
    if (byte.TryParse(Console.ReadLine(), out var parsedAge))
    {
        age = parsedAge;
    }
    else
    {
        Console.WriteLine("Input age is not valid!");
        Console.ReadKey();
        return true;
    }

    return false;
}

Student? GetStudent(StudentsRepository studentsRepository, out string id)
{
    Console.Write("Enter student id: ");
    id = Console.ReadLine();
    var student = studentsRepository.GetStudent(id);

    return student;
}