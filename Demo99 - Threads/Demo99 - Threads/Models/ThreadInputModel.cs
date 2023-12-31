namespace Demo99___Threads.Models;

public class ThreadInputModel
{
    public ThreadInputModel(int from, int to)
    {
        From = from;
        To = to;
    }

    public int From { get; set; }
    public int To { get; set; }
}