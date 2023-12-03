using Demo95___ADO.NET__UsersManagement_.Models;
using Microsoft.Data.SqlClient;

namespace Demo95___ADO.NET__UsersManagement_.Repositories;

public class UsersRepository
{
    private SqlConnection connection;

    public UsersRepository()
    {
        connection = new SqlConnection(Constants.ConnectionString);
    }

    public bool CreateUser(string username, string password)
    {
        try
        {
            connection.Open();
            var command = CreateCommand("INSERT INTO Users VALUES (@p1, @p2, @p3)", new Dictionary<string, object>()
            {
                ["p1"] = username,
                ["p2"] = password,
                ["p3"] = DateTime.Now
            });
            command.ExecuteNonQuery();
            connection.Close();;
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }

    public bool ExistsUser(string username)
    {
        connection.Open();
        var command = CreateCommand("SELECT COUNT(*) FROM Users where Username = @p1", new Dictionary<string, object>()
        {
            ["p1"] = username
        });
        var result = (int)command.ExecuteScalar();
        connection.Close();
        return result > 0;
    }

    public bool ChangePassword(string username, string newPassword)
    {
        connection.Open();
        var command = CreateCommand("UPDATE Users SET Password = @p1 WHERE Username = @p2", new Dictionary<string, object>()
        {
            ["p1"] = newPassword,
            ["p2"] = username
        });
        var result = (int)command.ExecuteNonQuery();
        return result > 0;
    }

    public List<User> GetAll()
    {
        var users = new List<User>();
        connection.Open();
        var command = CreateCommand("SELECT * FROM Users ORDER BY Username", new Dictionary<string, object>());
        var reader = command.ExecuteReader();
        while (reader.Read())
        {
            users.Add(new User()
            {
                Id = reader.GetInt32(0),
                Username = reader.GetString(1),
                Password = reader.GetString(2),
                RegisterDate = reader.GetDateTime(3)
            });
        }

        return users;
    }

    public bool ValidateUser(string username, string password)
    {
        try
        {
            connection.Open();
            var command = CreateCommand("SELECT COUNT(*) FROM Users WHERE Username = @p1 and Password = @p2",
                new Dictionary<string, object>()
                {
                    ["p1"] = username,
                    ["p2"] = password
                });
            var result = (int)command.ExecuteScalar();
            connection.Close();
            return result > 0;
        }
        catch (Exception e)
        {
            return false;
        }
    }

    public int Count
    {
        get
        {
            connection.Open();
            var command = CreateCommand("SELECT COUNT(*) FROM Users", new Dictionary<string, object>());
            var result = (int)command.ExecuteScalar();
            connection.Close();
            return result;
        }
    }

    private SqlCommand CreateCommand(string commandText, Dictionary<string, object> parameters)
    {
        var command = new SqlCommand(commandText, connection);
        foreach (var parameter in parameters)
        {
            command.Parameters.Add(new SqlParameter(parameter.Key, parameter.Value));
        }
        return command;
    }
}