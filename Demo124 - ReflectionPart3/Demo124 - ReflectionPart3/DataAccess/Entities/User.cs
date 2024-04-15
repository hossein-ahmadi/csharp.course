using Demo124___ReflectionPart3.DataAccess.MappingAttributes;

namespace Demo124___ReflectionPart3.DataAccess.Entities;

[EntityTable("Users")]
public class User
{
    [PrimaryKey]
    [IdentityColumn]
    public int Id { get; set; }

    public string Username { get; set; }
    public string Password { get; set; }
    public DateTime RegisterDate { get; set; }
}