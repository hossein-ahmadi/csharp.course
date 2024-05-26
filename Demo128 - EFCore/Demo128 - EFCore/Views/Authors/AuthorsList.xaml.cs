using System.Windows;
using Demo128___EFCore.DbModel.Entities;
using Demo128___EFCore.DbModel;
using Demo128___EFCore.ViewModels.Authors;
using Microsoft.Extensions.DependencyInjection;

namespace Demo128___EFCore.Views.Authors
{
    /// <summary>
    /// Interaction logic for AuthorsList.xaml
    /// </summary>
    public partial class AuthorsList : Window
    {
        private readonly AuthorsListViewModel viewModel;
        private readonly IServiceProvider services;

        public AuthorsList(AuthorsListViewModel viewModel, IServiceProvider services)
        {
            this.viewModel = viewModel;
            this.services = services;
            this.DataContext = viewModel;
            InitializeComponent();
        }

        private void AddNewAuthorButton_Click(object sender, RoutedEventArgs e)
        {
            var editorWindow = services.GetService<Views.Authors.AuthorEditor>();
            if (editorWindow != null)
            {
                var dialogResult = editorWindow.ShowDialog();
                if ((dialogResult ?? false) && editorWindow.Author != null)
                {
                    viewModel.Authors.Add(editorWindow.Author);
                }
            }
        }

        private void EditAuthorWindow_Click(object sender, RoutedEventArgs e)
        {
            var selectedAuthor = AuthorsDataGrid.SelectedItem as DbModel.Entities.Author;
            if (selectedAuthor == null)
            {
                MessageBox.Show("ابتدا یک نویسنده را انتخاب کنید");
                return;
            }

            var editorWindow = services.GetService<Views.Authors.AuthorEditor>();
            editorWindow.Author = selectedAuthor;
            editorWindow.ShowDialog();
            AuthorsDataGrid.ItemsSource = null;
            AuthorsDataGrid.ItemsSource = viewModel.Authors;
        }

        private void DeleteAuthorButton_Click(object sender, RoutedEventArgs e)
        {
            if (AuthorsDataGrid.SelectedItem == null)
            {
                MessageBox.Show("ابتدا یک عضو را انتخاب کنید");
                return;
            }
            if (MessageBox.Show("آیا از حذف رکورد مطمئن هستید؟", "حذف رکورد", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                var author = (Author)AuthorsDataGrid.SelectedItem;
                var dbContext = services.GetService<ApplicationDbContext>();
                var memberToRemove = dbContext.Authors.Find(author.Id);
                dbContext.Authors.Remove(memberToRemove);
                dbContext.SaveChanges();
                viewModel.Authors.Remove(author);
            }
        }
    }
}
