namespace Demo57___SingletonPattern;

public class EmailSender
{
    private EmailSender(){}

    private static EmailSender? instance;


    public static EmailSender Instance
    {
        get
        {
            if (instance == null)
                instance = new EmailSender();
            return instance;
        }
    }

    public bool Send(string email, string subject, string body)
    {
        return true;
    }
}