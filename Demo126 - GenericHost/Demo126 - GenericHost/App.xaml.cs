using System.Configuration;
using System.Data;
using System.Windows;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Demo126___GenericHost
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override async void OnStartup(StartupEventArgs e)
        {
            HostApplicationBuilder builder = Host.CreateApplicationBuilder(e.Args);
            builder.Logging.ClearProviders();
            builder.Logging.AddConsole();
            builder.Services.AddHostedService<Infrastructure.ApplicationHostedService>();
            builder.Configuration.AddJsonFile("appsettings.json");
            builder.Environment.EnvironmentName = builder.Configuration["Environment"]!;
            AddServices(builder.Services);

            var host = builder.Build();
            await host.RunAsync();
        }

        private void AddServices(IServiceCollection services)
        {
            services.AddTransient<MainWindow>();
        }
    }

}
