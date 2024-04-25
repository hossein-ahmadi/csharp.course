using System;
using System.Reflection;
using Demo124___ReflectionPart3.DataAccess.MappingAttributes;
using Demo124___ReflectionPart3.DataAccess.Models;
using Microsoft.Data.SqlClient;

namespace Demo124___ReflectionPart3.DataAccess.SqlServer;

public abstract class SqlGenericRepository<T> where T : class, new()
{
    protected readonly SqlConnection Connection;

    protected readonly EntityMap EntityMap;

    public SqlGenericRepository(SqlConnection connection)
    {
        this.Connection = connection;
        EntityMap = new EntityMap(typeof(T));
    }

    public int Count()
    {
        Connection.Open();

        var command = new SqlCommand($"SELECT COUNT(*) FROM [{EntityMap.TableName}]", Connection);

        var result = (int)command.ExecuteScalar();

        Connection.Close();

        return result;
    }

    public void Add(T entity)
    {
        List<string> columnNames = new List<string>();

        Dictionary<string, SqlParameter> parameters = new Dictionary<string, SqlParameter>();

        var index = 1;
        foreach (var propertyItem in EntityMap.Properties)
        {
            var property = propertyItem.Value;
            columnNames.Add(property.Name);
            parameters.Add($"p{(index)}", new SqlParameter($"p{(index)}", property.GetValue(entity)));
            index++;
        }


        var insertColumnNames = string.Join(", ", columnNames);
        var insertParameters = string.Join(", ", parameters.Select(p => "@" + p.Key));

        var insertStatement = $"INSERT INTO [{EntityMap.TableName}] ({insertColumnNames}) VALUES ({insertParameters})";

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
        List<string> deleteWhereParts = new List<string>();
        Dictionary<string, object> parameters = new Dictionary<string, object>();

        var parametersIndex = 1;

        foreach (var primaryKey in EntityMap.PrimaryKeyProperties)
        {
            deleteWhereParts.Add($"[{primaryKey.Value.Name}] = @p{parametersIndex}");
            parameters.Add($"p{parametersIndex}", primaryKey.Value.GetValue(entity));
            parametersIndex++;
        }


        var updateStatement = $"DELETE FROM [{EntityMap.TableName}] WHERE {string.Join(" AND ", deleteWhereParts)}";

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
        List<string> updateStatementParts = new List<string>();
        List<string> updateWhereParts = new List<string>();
        Dictionary<string, object> parameters = new Dictionary<string, object>();

        var parametersIndex = 1;
        foreach (var property in EntityMap.Properties)
        {
            updateStatementParts.Add($"[{property.Value.Name}] = @p{parametersIndex}");

            parameters.Add($"p{parametersIndex}", property.Value.GetValue(entity));
            parametersIndex++;
        }

        foreach (var primaryKey in EntityMap.PrimaryKeyProperties)
        {
            updateWhereParts.Add($"[{primaryKey.Value.Name}] = @p{parametersIndex}");
            parameters.Add($"p{parametersIndex}", primaryKey.Value.GetValue(entity));
            parametersIndex++;
        }


        var updateStatement = $"UPDATE [{EntityMap.TableName}] SET {string.Join(", ", updateStatementParts)} WHERE {string.Join(" AND ", updateWhereParts)}";

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