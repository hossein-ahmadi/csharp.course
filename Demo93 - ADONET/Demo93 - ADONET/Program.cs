// Demo92 - ADO.NET Introduction
// TOSINSO C# Mega Course

using Microsoft.Data.SqlClient;

var connection = new Microsoft.Data.SqlClient.SqlConnection("Data Source=.;Initial Catalog=AccountingDB; Integrated Security=True; TrustServerCertificate=True;");

connection.Open();

var checkUserExistsCommand = new SqlCommand("SELECT COUNT(*) FROM Users where [Username] = 'admin'", connection);
var adminUsersCount = (int)checkUserExistsCommand.ExecuteScalar();
if (adminUsersCount == 0)
{
    var insertCommandText = $"INSERT INTO [Users] ([Username],[Password],[RegisterDate]) VALUES ('admin','123','{DateTime.Now.ToString()}')";

    var insertCommand = new Microsoft.Data.SqlClient.SqlCommand(insertCommandText, connection);

    var result = insertCommand.ExecuteNonQuery();
}

connection.Close();