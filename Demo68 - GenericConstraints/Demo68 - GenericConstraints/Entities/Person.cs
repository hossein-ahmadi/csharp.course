using Demo68___GenericConstraints.BaseTypes;

namespace Demo68___GenericConstraints.Entities;

public class Person : EntityBase, IComparable<Person>
{
    public string FirstnaName { get; set; }
    public string Lastname { get; set; }

    public int CompareTo(Person? other)
    {
        throw new NotImplementedException();
    }
}