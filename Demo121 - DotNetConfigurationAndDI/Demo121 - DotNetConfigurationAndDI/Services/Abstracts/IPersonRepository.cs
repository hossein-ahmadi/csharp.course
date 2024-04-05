using Demo121___DotNetConfigurationAndDI.Models;

namespace Demo121___DotNetConfigurationAndDI.Services.Abstracts;

public interface IPersonRepository
{
    public Models.Person GetPerson(int id);
}