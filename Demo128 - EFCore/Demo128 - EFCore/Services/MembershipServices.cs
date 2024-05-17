using System.Security.Cryptography;
using Demo128___EFCore.DbModel;
using Demo128___EFCore.DbModel.Entities;
using Microsoft.EntityFrameworkCore;

namespace Demo128___EFCore.Services;

public class MembershipServices(ApplicationDbContext dbContext)
{
    public async Task<bool> UserExistsAsync(string username)
    {
        return await dbContext.Users.AnyAsync(u => u.Username == username);
    }

    public async Task<int> CreateUserAsync(string username, string password, string role = "user")
    {
        var passwordSalt = Guid.NewGuid().ToString("N");
        var user = new User()
        {
            Username = username,
            Password = HashPassword(password, passwordSalt),
            PasswordSalt = passwordSalt,
            RegisterDate = DateTime.Now,
            Role = role
        };
        dbContext.Users.Add(user);
        await dbContext.SaveChangesAsync();
        return user.Id;
    }

    public async Task<bool> UserIsValidAsync(string username, string password)
    {
        var user = await dbContext.Users.FirstOrDefaultAsync(u => u.Username == username);
        if (user == null)
            return false;
        return user.Password == HashPassword(password, user.PasswordSalt);
    }

    private string HashPassword(string password, string passwordSalt)
    {
        var hasher = SHA256.Create();
        var hashedPassword = Convert.ToBase64String(hasher.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password + passwordSalt)));
        return hashedPassword;
    }
}