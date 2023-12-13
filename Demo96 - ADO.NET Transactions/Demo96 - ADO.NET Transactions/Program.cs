// Demo96 - ADO.NET Transactions
// TOSINSO C# Mega Course

using Microsoft.Data.SqlClient;

using var connection = new SqlConnection("Data Source=.; Initial Catalog=AccountingDb; Integrated Security=true; TrustServerCertificate=true");
connection.Open();
var transaction = connection.BeginTransaction();

try
{
    var increaseCommand = new SqlCommand("INSERT INTO Transactions VALUES (@p1,@p2,@p3)", connection);
    increaseCommand.Transaction = transaction;
    increaseCommand.Parameters.Add(new SqlParameter("p1", 1));
    increaseCommand.Parameters.Add(new SqlParameter("p2", DateTime.Now));
    increaseCommand.Parameters.Add(new SqlParameter("p3", 10000));
    increaseCommand.ExecuteNonQuery();
    var decreaseCommand = new SqlCommand("INSERT INTO Transactions VALUES (@p1,@p2,@p3)", connection);
    decreaseCommand.Transaction = transaction;
    decreaseCommand.Parameters.Add(new SqlParameter("p1", 2));
    decreaseCommand.Parameters.Add(new SqlParameter("p2", DateTime.Now));
    decreaseCommand.Parameters.Add(new SqlParameter("p3", -10000));
    decreaseCommand.ExecuteNonQuery();
    transaction.Commit();
}
catch (Exception e)
{
    transaction.Rollback();
    Console.WriteLine(e);
    throw;
}

connection.Close();