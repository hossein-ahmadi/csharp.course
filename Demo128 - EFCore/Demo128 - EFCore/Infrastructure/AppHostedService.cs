using Demo128___EFCore.DbModel.Entities;
using Demo128___EFCore.Views;
using Microsoft.Extensions.Hosting;

namespace Demo128___EFCore.Infrastructure;

public class AppHostedService(LoginView loginView, DbModel.ApplicationDbContext dbContext) : IHostedService
{
    public Task StartAsync(CancellationToken cancellationToken)
    {
        if (dbContext.Users.Count() == 0)
        {
            dbContext.Users.Add(new User()
            {
                Username = "admin",
                Password = "12345678",
                RegisterDate = DateTime.Now
            });
            dbContext.SaveChanges();
        }

        loginView.Show();
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}