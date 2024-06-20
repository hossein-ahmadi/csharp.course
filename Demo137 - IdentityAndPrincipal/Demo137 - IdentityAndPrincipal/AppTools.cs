namespace Demo137___IdentityAndPrincipal;

public class AppTools
{
    public void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to TOSINSO C# Course");
    }

    public void DisplayMessage2()
    {
        if (Thread.CurrentPrincipal.IsInRole("displaymessage2") || Thread.CurrentPrincipal.IsInRole("sysadmin"))
            Console.WriteLine("Only admins can see this message");
        else
            Console.WriteLine("You don't have rights to access this method!");
    }
}