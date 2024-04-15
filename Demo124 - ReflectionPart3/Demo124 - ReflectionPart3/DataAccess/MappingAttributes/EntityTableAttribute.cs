namespace Demo124___ReflectionPart3.DataAccess.MappingAttributes;

[AttributeUsage(AttributeTargets.Class)]
public class EntityTableAttribute : Attribute
{
    public EntityTableAttribute(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
}