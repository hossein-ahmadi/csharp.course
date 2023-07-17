namespace Demo58___ExtensionMethods.ExtensionMethods;

public static class PersonExtensions
{
    public static string Fullname(this Person person)
    {
        return $"{person.Firstname} {person.Lastname}";
    }

    public static string WelcomeMessage(this Person person, string message)
    {
        return $"{person.Fullname()}: {message}";
    }
}