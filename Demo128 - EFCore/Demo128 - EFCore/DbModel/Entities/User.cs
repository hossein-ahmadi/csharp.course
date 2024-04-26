namespace Demo128___EFCore.DbModel.Entities;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public bool IsSysAdmin { get; set; }
    public DateTime RegisterDate { get; set; }
}