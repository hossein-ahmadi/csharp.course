// Demo87 - LINQ Operators - Part 1
// TOSINSO C# Mega Course

using Demo87___LINQOperators1.Helpers;

var customers = DataHelpers.CreateCustomersAndOrders();

// Filtering

var numbers = new[]{1,3,2,6,9,4,8};

var numbersGreaterThanEight = numbers.Where(n=>n > 5);

var objectsList = new List<object>(){1,"Welcome to TOSINSO.COM", 1.4m};

var stringElements = objectsList.OfType<string>();

foreach (var element in stringElements)
{
    Console.WriteLine(element);
}

// Sorting

foreach (var customer in customers)
{
    Console.WriteLine(customer.Name);
}
Console.WriteLine("Order by ascending----------------");
foreach (var customer in customers.OrderBy(c=>c.Name))
{
    Console.WriteLine(customer.Name);
}
Console.WriteLine("Order by descending---------------");
foreach (var customer in customers.OrderByDescending(c => c.Name))
{
    Console.WriteLine(customer.Name);
}
Console.WriteLine("ThenBy operator");
foreach (var customer in customers.OrderByDescending(c=>c.Name).ThenBy(c=>c.Orders.Count))
{
    
}

// Projection

var projectedCustomers = customers.OrderByDescending(c=>c.Name).Select(c=> $"Customer {c.Name} has total {c.Orders.Count} orders.");
Console.WriteLine("Project to string output");
foreach (var projectedCustomer in projectedCustomers)
{
    Console.WriteLine(projectedCustomer);
}

var anonymousProjected = customers.Select(c=> new
{
    Id = c.Id,
    Description = $"{c.Name} has total {c.Orders.Count} orders."
});

var allOrders = customers.SelectMany(c=>c.Orders);

foreach (var order in allOrders)
{
    Console.WriteLine(order.Title);
}