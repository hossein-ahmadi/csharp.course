using System.Reflection;

namespace Demo124___ReflectionPart3.DataAccess.Models;

public class EntityMap
{
    public string TableName { get; private set; }

    public Dictionary<string, PropertyInfo> Properties { get; private set; }

    public Dictionary<string, PropertyInfo> IdentityProperties { get; private set; }

    public Dictionary<string, PropertyInfo> PrimaryKeyProperties { get; private set; }

    public EntityMap(Type type)
    {
        TableName = type.GetCustomAttribute<MappingAttributes.EntityTableAttribute>()?.Name ?? type.Name;

        var allProperties = type.GetProperties();

        Properties = allProperties.Where(p =>
                p.GetCustomAttribute(typeof(MappingAttributes.IdentityColumnAttribute)) == null)
            .ToDictionary(p => p.Name, p => p);

        IdentityProperties = allProperties.Where(p =>
                p.GetCustomAttribute(typeof(MappingAttributes.IdentityColumnAttribute)) != null)
            .ToDictionary(p => p.Name, p => p);

        PrimaryKeyProperties = allProperties.Where(p =>
                p.GetCustomAttribute(typeof(MappingAttributes.PrimaryKeyAttribute)) != null)
            .ToDictionary(p => p.Name, p => p);
    }
}