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
            services.AddTransient<ViewModels.MainViewModel>();
            services.AddTransient<ViewModels.Members.MemberListViewModel>();
            services.AddTransient<ViewModels.Members.MemberEditorViewModel>();
            services.AddTransient<ViewModels.Authors.AuthorsListViewModel>();
            services.AddTransient<ViewModels.Authors.AuthorEditorViewModel>();
            services.AddTransient<ViewModels.BookCategories.BookCategoriesListViewModel>();
            services.AddTransient<ViewModels.BookCategories.BookCategoryEditorViewModel>();
            services.AddTransient<ViewModels.Books.BooksListViewModel>();
            services.AddTransient<ViewModels.Books.BookEditorViewModel>();

            services.AddTransient<Services.MembershipServices>();

            services.AddTransient<Views.LoginView>();
            services.AddTransient<Views.MainWindow>();
            services.AddTransient<Views.Members.MembersList>();
            services.AddTransient<Views.Members.MemberEditor>();
            services.AddTransient<Views.Authors.AuthorsList>();
            services.AddTransient<Views.Authors.AuthorEditor>();
            services.AddTransient<Views.BookCategories.BookCategoriesList>();
            services.AddTransient<Views.BookCategories.BookCategoryEditor>();
            services.AddTransient<Views.Books.BooksListView>();
            services.AddTransient<Views.Books.BookEditorView>();
        }
    }

}
