using Demo68___GenericConstraints.BaseTypes;

namespace Demo68___GenericConstraints.Services;

public class GenericRepository<T> where T : EntityBase, IComparable<T>, new()
{
    T[] entities = new T[10];

    public void Add(T entity)
    {
        var newEntity = new T(); // where T : new()
        // add entity to array
    }

    public T? Get(int id)
    {
        return default;
    }

    public void Update(T entity)
    {
        // add code for updating entity
    }
}