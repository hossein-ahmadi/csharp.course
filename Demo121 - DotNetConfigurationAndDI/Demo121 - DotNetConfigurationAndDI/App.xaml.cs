using System.Configuration;
using System.Data;
using System.IO;
using System.Windows;
using Demo121___DotNetConfigurationAndDI.Services.Abstracts;
using Demo121___DotNetConfigurationAndDI.Services.Concretes;
using Demo121___DotNetConfigurationAndDI.ViewModels;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Demo121___DotNetConfigurationAndDI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IConfiguration Configuration { get; private set; }
        public static IServiceProvider Services { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            Configuration = builder.Build();
            
            var serviceCollection = new ServiceCollection();

            ConfigureServices(serviceCollection);

            Services = serviceCollection.BuildServiceProvider();

            var mainWindow = Services.GetService<MainWindow>();
            mainWindow.Show();
        }

        private void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IPersonRepository, SqlPersonRepository>();
            serviceCollection.AddTransient<ViewModels.PersonViewModel>();
            serviceCollection.AddTransient<MainWindow>();
        }
    }

}
