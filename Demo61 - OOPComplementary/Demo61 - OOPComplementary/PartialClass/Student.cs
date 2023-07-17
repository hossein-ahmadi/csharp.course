namespace Demo61___OOPComplementary.PartialClass;

public partial class Student
{
    public int Id { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }


    public int[] Scores { get; set; } = new int[10];

    // partial methods
    public partial void AddScores(params int[] scores);

    // Nested type
    public class StudentAddress
    {
        public string State { get; set; }
        public string City { get; set; }
    }
}