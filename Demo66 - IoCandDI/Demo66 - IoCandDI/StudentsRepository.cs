using Demo66___IoCandDI.Models;
using Demo66___IoCandDI.Services;
using Demo66___IoCandDI.ServicesAbstracts;

namespace Demo66___IoCandDI;

public class StudentsRepository
{
    private ILogger logger;

    public StudentsRepository(ILogger logger)
    {
        this.logger = logger;
    }

    public void Add(Student student)
    {
        logger.WriteToLog("log to file: Student added");
    }

    public void Delete(int id)
    {
        logger.WriteToLog("log to file: student deleted");
    }

    public void Update(Student student)
    {
        logger.WriteToLog("log to file: student updated");
    }
}