using Demo87___LINQOperators1.Models;

namespace Demo87___LINQOperators1.Helpers;

public static class DataHelpers
{
    public static List<Models.Customer> CreateCustomersAndOrders()
    {
        return new List<Customer>()
        {
            new Customer(1, "Hossein Ahmadi")
            {
                Orders = new List<Order>()
                {
                    new Order(1,1,"Product 1", 20000),
                    new Order(6,1,"Product 2", 25000),
                    new Order(3,1,"Product 3", 60000),
                    new Order(11,1,"Product 4", 10000),
                    new Order(8,1,"Product 5", 33500)
                }
            },
            new Customer(2, "Mehdi Adeli")
            {
                Orders = new List<Order>()
                {
                    new Order(2,2,"Product 1", 11700),
                    new Order(14,2,"Product 2", 33600),
                    new Order(9,2,"Product 3", 80000),
                    new Order(5,2,"Product 4", 47500),
                    new Order(10,2,"Product 5", 66500)
                }
            },
            new Customer(3, "Reza Mohammadi")
            {
                Orders = new List<Order>()
                {
                    new Order(4,3,"Product 1", 11700),
                    new Order(12,3,"Product 2", 33600),
                    new Order(7,3,"Product 3", 80000),
                    new Order(13,3,"Product 4", 47500),
                    new Order(15,3,"Product 5", 66500)
                }
            }
        };

    }
}