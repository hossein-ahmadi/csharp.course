using System.IO;
using System.Windows;
using Demo124___ReflectionPart3.DataAccess.Entities;
using Demo124___ReflectionPart3.DataAccess.SqlServer;
using Demo124___ReflectionPart3.Views;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Demo124___ReflectionPart3
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
                .AddJsonFile("appsettings.json", false, true);

            Configuration = builder.Build();

            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            Services = serviceCollection.BuildServiceProvider();

            var usersRepository = Services.GetService<UsersRepository>();

            var usersCount = usersRepository.Count();

            if (usersCount == 0)
            {
                usersRepository.Add(new User()
                {
                    Username = "admin",
                    Password = "123456",
                    RegisterDate = DateTime.Now
                });
            }

            var adminUser = usersRepository.GetByUsername("admin");


            usersRepository.Delete(adminUser);

            var loginWindow = Services.GetService<LoginWindow>();
            loginWindow.Show();
            base.OnStartup(e);
        }

        private void ConfigureServices(IServiceCollection collection)
        {
            collection.AddTransient<SqlConnection>(provider =>
            {
                var connectionString = Configuration.GetValue<string>("ConnectionStrings:AccountDb");
                var connection = new SqlConnection(connectionString);
                return connection;
            });
            collection.AddTransient<UsersRepository>();
            collection.AddTransient<ViewModels.LoginViewModel>();
            collection.AddTransient<Views.LoginWindow>();
        }
    }
}
