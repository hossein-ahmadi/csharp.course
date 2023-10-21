namespace Demo87___LINQOperators1.Models;

public class Customer
{
    public Customer(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public int Id { get; set; }
    public string Name { get; set; }

    public List<Order> Orders { get; set; } = new List<Order>();
}