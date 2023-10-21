namespace Demo88___LINQOperators2.Models;

public class Customer
{
    public Customer(int id, string province, string name)
    {
        Id = id;
        Province = province;
        Name = name;
    }

    public int Id { get; set; }
    public string Province { get; set; }
    public string Name { get; set; }

    public List<Order> Orders { get; set; } = new List<Order>();
}