// Demo88 - LINQ Operators Part 2
// TOSINSO C# Mega Course

using Demo88___LINQOperators2.Models;

var customers = new List<Customer>()
{
    new Customer(1, "Alborz", "Hossein Ahmadi"),
    new Customer(2, "Mazandaran", "Mehdi Adeli"),
    new Customer(3, "Tehran", "Mohammad Nasiri"),
    new Customer(4, "Alborz", "Alireza Fazeli"),
    new Customer(5, "Alborz", "Ali Shokrollahi"),
    new Customer(6, "Tehran", "Reza Ahmadi")
};

var orders = new List<Order>()
{
    new Order(1, 3, "Samsung Watch", 250000),
    new Order(2, 2, "IPhone 13 Pro Max", 500000)
};


// Group operators

var groupedCustomers = from c in customers
                       group c by c.Province into gp
                       select gp;

var groupedCustomersMethod2 = customers.GroupBy(c => c.Province);

foreach (var customer in groupedCustomersMethod2)
{
    Console.WriteLine(customer.Key);
    Console.WriteLine("----------------------");
    foreach (var c in customer)
    {
        Console.WriteLine(c.Name);
    }
}

// Join operator

var ordersWithCustomersName = (from o in orders
                              join c in customers on o.CustomerId equals c.Id
                              select new
                              {
                                  OrderId = o.Id,
                                  CustomerName = c.Name,
                                  o.Title,
                              }).ToList();

var ordersWithCustomersName2 = orders.Join(customers, order => order.CustomerId, customer => customer.Id,
    (order, customer) => new
    {
        OrderId = order.Id,
        CustomerName = customer.Name,
        order.Title,
    });

Console.WriteLine();
foreach (var order in ordersWithCustomersName)
{
    Console.WriteLine($"{order.CustomerName} ordered {order.Title}");
}