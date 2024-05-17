using Demo128___EFCore.Views;
using Microsoft.Extensions.Hosting;

namespace Demo128___EFCore.Infrastructure;

public class AppHostedService(LoginView loginView, Services.MembershipServices membership) : IHostedService
{
    public async Task StartAsync(CancellationToken cancellationToken)
    {
        if (!(await membership.UserExistsAsync("admin")))
        {
            await membership.CreateUserAsync("admin", "123456", "sysadmin");
        }

        loginView.Show();
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}