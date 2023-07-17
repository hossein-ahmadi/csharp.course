namespace Demo61___OOPComplementary;

public class EmailSender
{
    private EmailSender(){}


    private static EmailSender? instance;

    public static EmailSender Instance
    {
        get
        {
            // Null coalesce assignment
            return instance ??= new EmailSender();
        }
    }

    public bool Send(string email, string subject, string body)
    {
        return true;
    }
}