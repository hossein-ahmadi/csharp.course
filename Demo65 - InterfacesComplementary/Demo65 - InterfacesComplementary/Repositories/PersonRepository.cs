using System.Collections;
using Demo65___InterfacesComplementary.Models;

namespace Demo65___InterfacesComplementary.Repositories;

public class PersonRepository : IEnumerable
{
    private Person[] persons = new Person[10];

    public void Add(Person person)
    {
        var indexToAdd = 0;

        for (int i = 0; i < persons.Length; i++)
        {
            if (persons[i] == null)
            {
                indexToAdd = i;
                break;
            }
        }

        persons[indexToAdd] = person;
    }

    public IEnumerator GetEnumerator()
    {
        foreach (var p in persons)
        {
            if(p == null)
                continue;
            yield return p;
        }
    }
}