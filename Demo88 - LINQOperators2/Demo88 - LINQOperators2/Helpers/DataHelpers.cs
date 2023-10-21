using Demo88___LINQOperators2.Models;

namespace Demo88___LINQOperators2.Helpers;

public static class DataHelpers
{
    public static List<Models.Customer> CreateCustomersAndOrders()
    {
        return new List<Customer>()
        {
            new Customer(1,"Alborz", "Hossein Ahmadi")
            {
                Orders = new List<Order>()
                {
                    new Order(1,1,"Product 1", 20000),
                    new Order(6,1,"Product 4", 25000),
                    new Order(3,1,"Product 2", 60000),
                    new Order(11,1,"Product 1", 10000),
                    new Order(8,1,"Product 3", 33500)
                }
            },
            new Customer(2,"Mazandaran", "Mehdi Adeli")
            {
                Orders = new List<Order>()
                {
                    new Order(2,2,"Product 1", 11700),
                    new Order(14,2,"Product 2", 33600),
                    new Order(9,2,"Product 1", 80000),
                    new Order(5,2,"Product 3", 47500),
                    new Order(10,2,"Product 4", 66500)
                }
            },
            new Customer(3,"Alborz", "Reza Mohammadi")
            {
                Orders = new List<Order>()
                {
                    new Order(4,3,"Product 1", 11700),
                    new Order(12,3,"Product 3", 33600),
                    new Order(7,3,"Product 1", 80000),
                    new Order(13,3,"Product 5", 47500),
                    new Order(15,3,"Product 2", 66500)
                }
            },
            new Customer(4,"Tehran", "Mohammad Nasiri")
            {
                Orders = new List<Order>()
                {
                    new Order(4,4,"Product 1", 11700),
                    new Order(12,4,"Product 4", 33600),
                    new Order(7,4,"Product 1", 80000),
                    new Order(13,4,"Product 5", 47500),
                    new Order(15,4,"Product 1", 66500)
                }
            }
        };

    }
}