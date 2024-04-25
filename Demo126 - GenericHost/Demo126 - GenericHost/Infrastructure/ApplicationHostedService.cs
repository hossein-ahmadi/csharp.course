using System.Windows;
using Microsoft.Extensions.Hosting;

namespace Demo126___GenericHost.Infrastructure;

public class ApplicationHostedService(MainWindow mainWindow) : IHostedService
{
    public Task StartAsync(CancellationToken cancellationToken)
    {
        mainWindow.Show();
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}