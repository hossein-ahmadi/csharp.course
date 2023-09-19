// Demo76 - Covariance and Contravariance
// TOSINSO C# Mega Course


// Covariance sample
IBase<string> strBase = new Child<string>();

IBase<object> objBase = strBase;

IEnumerable<string> strEnumerable = new List<string>();

IEnumerable<object> objEnumerable = strEnumerable;

// Contravariance sample
IBase2<object> objBase2 = new Child2<object>();

IBase2<string> strBase2 = objBase2;

Action<object> objAction = obj =>
{
    Console.WriteLine(obj?.ToString());
};

Action<string> strAction = objAction;

public interface IBase<out T>
{
    public T Dosomething();
}

public class Child<T> : IBase<T>
{
    public T Dosomething()
    {
        throw new NotImplementedException();
    }
}

public interface IBase2<in T>
{
    public void Domesomething(T input)
    {

    }
}

public class Child2<T> : IBase2<T>
{

}