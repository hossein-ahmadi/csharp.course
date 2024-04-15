using System.Reflection;
using System.Text;
using Demo124___ReflectionPart3.DataAccess.MappingAttributes;
using Microsoft.Data.SqlClient;

namespace Demo124___ReflectionPart3.DataAccess.SqlServer;

public abstract class SqlGenericRepository<T> where T : class, new()
{
    protected readonly SqlConnection Connection;

    public SqlGenericRepository(SqlConnection connection)
    {
        this.Connection = connection;
    }

    public int Count()
    {
        Connection.Open();

        var entityType = typeof(T);
        var tableAttribute = entityType.GetCustomAttribute(typeof(EntityTableAttribute)) as EntityTableAttribute;

        var command = new SqlCommand($"SELECT COUNT(*) FROM [{tableAttribute.Name}]", Connection);

        var result = (int)command.ExecuteScalar();

        Connection.Close();

        return result;
    }

    public void Add(T entity)
    {
        var entityType = typeof(T);
        var tableAttribute = entityType.GetCustomAttribute(typeof(EntityTableAttribute)) as EntityTableAttribute;

        var properties = entityType.GetProperties();

        List<string> columnNames = new List<string>();

        Dictionary<string, SqlParameter> parameters = new Dictionary<string, SqlParameter>();

        for (var index = 0; index < properties.Length; index++)
        {
            var property = properties[index];
            if(property.GetCustomAttribute(typeof(IdentityColumnAttribute)) != null)
                continue;
            columnNames.Add(property.Name);
            parameters.Add($"p{(index + 1)}", new SqlParameter($"p{(index + 1)}", property.GetValue(entity)));
        }


        var insertColumnNames = string.Join(", ", columnNames);
        var insertParameters = string.Join(", ", parameters.Select(p => "@" + p.Key));

        var insertStatement = $"INSERT INTO [{tableAttribute.Name}] ({insertColumnNames}) VALUES ({insertParameters})";

        var command = new SqlCommand(insertStatement, Connection);

        foreach (var parameter in parameters)
        {
            command.Parameters.Add(parameter.Value);
        }
        Connection.Open();
        command.ExecuteNonQuery();
        Connection.Close();
    }

    public void Delete(T entity)
    {
        var entityType = typeof(T);
        var tableAttribute = entityType.GetCustomAttribute(typeof(EntityTableAttribute)) as EntityTableAttribute;

        var properties = entityType.GetProperties();

        var primaryKeys = properties.Where(p => p.GetCustomAttribute(typeof(PrimaryKeyAttribute)) != null).ToList();

        List<string> deleteWhereParts = new List<string>();
        Dictionary<string, object> parameters = new Dictionary<string, object>();

        var parametersIndex = 1;

        foreach (var primaryKey in primaryKeys)
        {
            deleteWhereParts.Add($"[{primaryKey.Name}] = @p{parametersIndex}");
            parameters.Add($"p{parametersIndex}", primaryKey.GetValue(entity));
            parametersIndex++;
        }


        var updateStatement = $"DELETE FROM [{tableAttribute.Name}] WHERE {string.Join(" AND ", deleteWhereParts)}";

        Connection.Open();

        var command = new SqlCommand(updateStatement, Connection);
        foreach (var parameter in parameters)
        {
            command.Parameters.Add(new SqlParameter(parameter.Key, parameter.Value));
        }

        command.ExecuteNonQuery();
    }

    public void Update(T entity)
    {
        var entityType = typeof(T);
        var tableAttribute = entityType.GetCustomAttribute(typeof(EntityTableAttribute)) as EntityTableAttribute;

        var properties = entityType.GetProperties();

        var primaryKeys = properties.Where(p => p.GetCustomAttribute(typeof(PrimaryKeyAttribute)) != null).ToList();

        List<string> updateStatementParts = new List<string>();
        List<string> updateWhereParts = new List<string>();
        Dictionary<string, object> parameters = new Dictionary<string, object>();

        var parametersIndex = 1;
        foreach (var property in properties)
        {
            if (property.GetCustomAttribute(typeof(IdentityColumnAttribute)) != null)
                continue;

            updateStatementParts.Add($"[{property.Name}] = @p{parametersIndex}");

            parameters.Add($"p{parametersIndex}", property.GetValue(entity));
            parametersIndex++;
        }

        foreach (var primaryKey in primaryKeys)
        {
            updateWhereParts.Add($"[{primaryKey.Name}] = @p{parametersIndex}");
            parameters.Add($"p{parametersIndex}", primaryKey.GetValue(entity));
            parametersIndex++;
        }


        var updateStatement = $"UPDATE [{tableAttribute.Name}] SET {string.Join(", ", updateStatementParts)} WHERE {string.Join(" AND ", updateWhereParts)}";

        Connection.Open();

        var command = new SqlCommand(updateStatement, Connection);
        foreach (var parameter in parameters)
        {
            command.Parameters.Add(new SqlParameter(parameter.Key, parameter.Value));
        }

        command.ExecuteNonQuery();
    }

    public List<T> Query(string query, object? parameters = null)
    {
        List<T> entities = new List<T>();
        Connection.Open();
        var command = new SqlCommand(query, Connection);

        if (parameters != null)
        {
            var parametersProperties = parameters.GetType().GetProperties();

            foreach (var parameter in parametersProperties)
            {
                var sqlParameter = new SqlParameter(parameter.Name, parameter.GetValue(parameters));
                command.Parameters.Add(sqlParameter);
            }
        }

        var reader = command.ExecuteReader();
        var entityType = typeof(T);

        var entityProperties = entityType.GetProperties()
            .ToDictionary(c => c.Name, c => c);

        while (reader.Read())
        {
            var instance = Activator.CreateInstance<T>();

            for (int index = 0; index < reader.FieldCount; index++)
            {
                var name = reader.GetName(index);
                if (entityProperties.ContainsKey(name))
                {
                    entityProperties[name].SetValue(instance, reader.GetValue(index));
                }
            }

            entities.Add(instance);
        }
        Connection.Close();
        return entities;
    }
}