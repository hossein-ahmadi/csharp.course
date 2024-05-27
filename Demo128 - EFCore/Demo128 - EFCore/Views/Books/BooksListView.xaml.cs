using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Demo128___EFCore.DbModel;
using Demo128___EFCore.ViewModels.Books;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Demo128___EFCore.Views.Books
{
    /// <summary>
    /// Interaction logic for BooksListView.xaml
    /// </summary>
    public partial class BooksListView : Window
    {
        private readonly BooksListViewModel viewModel;
        private readonly IServiceProvider services;

        public BooksListView(ViewModels.Books.BooksListViewModel viewModel ,IServiceProvider services)
        {
            this.viewModel = viewModel;
            this.services = services;
            this.DataContext = viewModel;
            InitializeComponent();
        }

        private void AddBookButton_Click(object sender, RoutedEventArgs e)
        {
            var editorView = services.GetService<Views.Books.BookEditorView>();
            var showDialog = editorView?.ShowDialog();
            if (showDialog ?? false)
            {
                viewModel.ReloadItems();
                BooksDataGrid.ItemsSource = null;
                BooksDataGrid.ItemsSource = viewModel.Books;
            }
        }

        private void EditBookButton_OnClick(object sender, RoutedEventArgs e)
        {
            var dbContext = services.GetService<ApplicationDbContext>();
            var selectedBook = BooksDataGrid.SelectedItem as ViewModels.Books.QueryModels.BookModel;
            if (selectedBook == null)
                return;
            var editorView = services.GetService<Views.Books.BookEditorView>();
            editorView.Book = dbContext.Books
                .Include(b=>b.Authors)
                .Include(b=>b.Category)
                .First(b => b.Id == selectedBook.Id);
            var showDialog = editorView.ShowDialog();
            if (showDialog ?? false)
            {
                viewModel.ReloadItems();
                BooksDataGrid.ItemsSource = null;
                BooksDataGrid.ItemsSource = viewModel.Books;
            }
        }
    }
}