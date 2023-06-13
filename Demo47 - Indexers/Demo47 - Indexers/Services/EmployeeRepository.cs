using Demo47___Indexers.Models;

namespace Demo47___Indexers.Services;

public class EmployeeRepository
{
    private Models.Employee[] employees = new Employee[10];

    public void Add(Models.Employee employee)
    {
        for (int index = 0; index < employees.Length; index++)
        {
            if (employees[index] == null)
            {
                employees[index] = employee;
                break;
            }
        }
    }

    public Employee Get(int index)
    {
        return employees[index];
    }

    public Employee this[int index]
    {
        get
        {
            return employees[index];
        }
        set
        {
            employees[index] = value;
        }
    }

    public Employee this[string id]
    {
        get
        {
            foreach (var employee in employees)
            {
                if(employee.Id == id)
                    return employee;
            }

            return null;
        }
    }
}