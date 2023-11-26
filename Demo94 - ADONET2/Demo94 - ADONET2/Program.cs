// Demo94 - ADO.NET Part 2
// TOSINSO C# Mega Course

using Microsoft.Data.SqlClient;

using var connection = new SqlConnection("Data Source=.; Initial Catalog=AccountingDb; Integrated Security=true; TrustServerCertificate=true");

Console.Write("Username: ");
var username = Console.ReadLine();
Console.Write("Password: ");
var password = Console.ReadLine();


var query = $"SELECT COUNT(*) FROM Users WHERE Username = @p1 and Password = @p2";

var usernameParameter = new SqlParameter("p1", username);
var passwordParameter = new SqlParameter("p2", password);
var command = new SqlCommand(query, connection);
command.Parameters.Add(usernameParameter);
command.Parameters.Add(passwordParameter);

connection.Open();
var usersCount = command.ExecuteScalar();

connection.Open();