using System.Windows;
using Demo128___EFCore.DbModel.Entities;
using Demo128___EFCore.DbModel;
using Microsoft.Extensions.DependencyInjection;

namespace Demo128___EFCore.Views.BookCategories
{
    /// <summary>
    /// Interaction logic for AuthorsList.xaml
    /// </summary>
    public partial class BookCategoriesList : Window
    {
        private readonly ViewModels.BookCategories.BookCategoriesListViewModel viewModel;
        private readonly IServiceProvider services;

        public BookCategoriesList(ViewModels.BookCategories.BookCategoriesListViewModel viewModel, IServiceProvider services)
        {
            this.viewModel = viewModel;
            this.services = services;
            this.DataContext = viewModel;
            InitializeComponent();
        }

        private void AddNewBookCategory_Click(object sender, RoutedEventArgs e)
        {
            var editorWindow = services.GetService<Views.BookCategories.BookCategoryEditor>();
            if (editorWindow != null)
            {
                var dialogResult = editorWindow.ShowDialog();
                if ((dialogResult ?? false) && editorWindow.BookCategory != null)
                {
                    viewModel.Categories.Add(editorWindow.BookCategory);
                }
            }
        }

        private void EditBookCategoryWindow_Click(object sender, RoutedEventArgs e)
        {
            var selectedCategory = BookCategoriesDataGrid.SelectedItem as DbModel.Entities.BookCategory;
            if (selectedCategory == null)
            {
                MessageBox.Show("ابتدا یک دسته بندی را انتخاب کنید");
                return;
            }

            var editorWindow = services.GetService<Views.BookCategories.BookCategoryEditor>();
            editorWindow.BookCategory = selectedCategory;
            editorWindow.ShowDialog();
            BookCategoriesDataGrid.ItemsSource = null;
            BookCategoriesDataGrid.ItemsSource = viewModel.Categories;
        }

        private void DeleteBookCategoryButton_Click(object sender, RoutedEventArgs e)
        {
            if (BookCategoriesDataGrid.SelectedItem == null)
            {
                MessageBox.Show("ابتدا یک دسته بندی را انتخاب کنید");
                return;
            }
            if (MessageBox.Show("آیا از حذف رکورد مطمئن هستید؟", "حذف رکورد", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                var author = (BookCategory)BookCategoriesDataGrid.SelectedItem;
                var dbContext = services.GetService<ApplicationDbContext>();
                var memberToRemove = dbContext.BookCategories.Find(author.Id);
                dbContext.BookCategories.Remove(memberToRemove);
                dbContext.SaveChanges();
                viewModel.Categories.Remove(author);
            }
        }
    }
}
