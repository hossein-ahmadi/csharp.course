namespace Demo123___ReflectionPart2;

public class Employee
{
    public Employee()
    {
        
    }

    public Employee(string firstname, string lastname, int salary)
    {
        Firstname = firstname;
        Lastname = lastname;
        Salary = salary;
    }

    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public int Salary { get; set; }

    public string GetFullname()
    {
        return $"{Firstname} {Lastname}";
    }

    public int CalculateTax(byte tax)
    {
        if (Salary < 10000000)
            return 0;

        return (Salary / 100) * tax;
    }
}