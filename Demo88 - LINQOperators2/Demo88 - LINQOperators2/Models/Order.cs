namespace Demo88___LINQOperators2.Models;

public class Order
{
    public Order(int id, int customerId, string title, int price)
    {
        Id = id;
        CustomerId = customerId;
        Title = title;
        Price = price;
    }

    public int Id { get; set; }
    public int CustomerId { get; set; }
    public string Title { get; set; }
    public int Price { get; set; }
}