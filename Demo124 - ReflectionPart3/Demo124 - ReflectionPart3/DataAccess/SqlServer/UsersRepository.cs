using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Demo124___ReflectionPart3.DataAccess.SqlServer;

public class UsersRepository : SqlGenericRepository<Entities.User>
{
    public UsersRepository(SqlConnection connection) : base(connection)
    {
    }

    public Entities.User? GetByUsername(string username)
    {
        return Query($"SELECT TOP(1) * FROM Users WHERE Username = @p1", new { p1 = username }).FirstOrDefault();
    }
}