using System.Windows;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Demo128___EFCore
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override async void OnStartup(StartupEventArgs e)
        {
            var appBuilder = Host.CreateApplicationBuilder(e.Args);
            appBuilder.Configuration.AddJsonFile("appsettings.json");
            appBuilder.Services.AddHostedService<Infrastructure.AppHostedService>();

            AddServices(appBuilder.Services);


            var host = appBuilder.Build();

            await host.RunAsync();
        }

        private void AddServices(IServiceCollection services)
        {
            services.AddDbContext<DbModel.ApplicationDbContext>(ServiceLifetime.Transient);
            services.AddTransient<ViewModels.LoginViewModel>();


            services.AddTransient<Views.LoginView>();
            services.AddTransient<Views.MainWindow>();
        }
    }

}
