// Demo132 - EF Core Transactions
// TOSINSO C# Mega Course

using Demo132___EFCoreTransactions.DbModel;
using Demo132___EFCoreTransactions.DbModel.Entities;

var context = new BlogDbContext();

await using var tr = await context.Database.BeginTransactionAsync();

try
{
    context.Blogs.Add(new Blog()
    {
        Title = "Alireza blog",
        Url = "afazeli"
    });

    await context.SaveChangesAsync();

    await tr.CommitAsync();
}
catch (Exception e)
{
    await tr.RollbackAsync();
    Console.WriteLine(e);
}
finally
{
    await tr.DisposeAsync();
}

Console.ReadKey();