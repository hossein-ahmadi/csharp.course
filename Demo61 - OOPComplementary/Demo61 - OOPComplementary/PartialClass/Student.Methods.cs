namespace Demo61___OOPComplementary.PartialClass;

public partial class Student
{
    public partial void AddScores(params int[] scores)
    {
        for (var index = 0; index < scores.Length; index++)
        {
            this.Scores[index] = scores[index];
        }
    }
}