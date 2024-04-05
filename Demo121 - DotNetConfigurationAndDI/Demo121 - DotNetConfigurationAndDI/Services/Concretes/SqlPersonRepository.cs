using Demo121___DotNetConfigurationAndDI.Models;

namespace Demo121___DotNetConfigurationAndDI.Services.Concretes;

public class SqlPersonRepository : Abstracts.IPersonRepository
{
    public Person GetPerson(int id)
    {
        return new Person()
        {
            Firstname = "Hossein",
            Lastname = "Ahmadi"
        };
    }
}