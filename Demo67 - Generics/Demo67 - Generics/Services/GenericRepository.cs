namespace Demo67___Generics.Services;

public class GenericRepository<T>
{
    T[] entities = new T[10];

    public void Add(T entity)
    {
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