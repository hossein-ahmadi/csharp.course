// Demo68 - Generic Constraints
// TOSINSO C# Mega Course

using Demo68___GenericConstraints.Entities;
using Demo68___GenericConstraints.Services;

var vh1 = new ValueHolder<int>(12);
// var vh3 = new ValueHolder<Person>(12);
// var vh2 = new ValueHolder<string>("TOSINSO.COM");


// var rth1 = new ReferenceTypeHolder<int>(12);
var rth2 = new ReferenceTypeHolder<string>("TOSINSO.COM");

// var repo1 = new GenericRepository<int>();

var repo1 = new GenericRepository<Person>();

public class ValueHolder<T> where T : struct
{
    public ValueHolder(T value)
    {
        this.Value = value;
    }

    public T Value { get; set; }
}

public class ReferenceTypeHolder<T> where T : class // where T : class? allow for nullable reference types
{
    public ReferenceTypeHolder(T value)
    {
        this.Value = value;
    }

    public T Value { get; set; }
}

public class MultiValueHolder<T1, T2>
    where T1 : struct
    where T2 : struct
{

}