using Demo74___AnonymousMethods.Models;

namespace Demo74___AnonymousMethods.Repositories;

public delegate void StudentsRepositoryNotificationsDelegate(Models.Student student);

public class OnUpdateStudentEventArgs : EventArgs
{
    public bool Success { get; set; }
    public Student Student { get; set; }
}

public class StudentsRepository
{
    public event StudentsRepositoryNotificationsDelegate? OnAddStudent;
    public event EventHandler<Models.Student>? OnDeleteStudent;

    public event EventHandler<OnUpdateStudentEventArgs>? OnUpdateStudent; 

    public void Add(Models.Student student)
    {
        // Add student to database
        if(OnAddStudent != null) 
            OnAddStudent(student);
    }

    public void Update(Models.Student student)
    {
        // Update student

        if (OnUpdateStudent != null)
        {
            OnUpdateStudent(this, new OnUpdateStudentEventArgs()
            {
                Success = true,
                Student = student
            });
        }
    }

    public Student Get(int id)
    {
        return new Student
        {
            Id = id,
            Firstname = "Alireza",
            Lastname = "Fazeli",
            Age = 30
        };
    }

    public void Delete(int id)
    {
        var student = Get(id);
        // Delete student
        if (OnDeleteStudent != null)
        {
            OnDeleteStudent(this, student);
        }
    }
}