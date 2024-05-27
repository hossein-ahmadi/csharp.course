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
using Demo128___EFCore.DbModel.Entities;
using Demo128___EFCore.ViewModels.Books;

namespace Demo128___EFCore.Views.Books
{
    /// <summary>
    /// Interaction logic for BookEditorView.xaml
    /// </summary>
    public partial class BookEditorView : Window
    {
        private readonly BookEditorViewModel viewModel;
        private readonly ApplicationDbContext dbContext;

        public Book? Book { get; set; }

        public BookEditorView(ViewModels.Books.BookEditorViewModel viewModel, ApplicationDbContext dbContext)
        {
            this.viewModel = viewModel;
            this.dbContext = dbContext;
            this.DataContext = viewModel;
            viewModel.OnSubmitSuccess += ViewModelOnOnSubmitSuccess;
            InitializeComponent();
        }

        protected override void OnActivated(EventArgs e)
        {
            if (Book != null)
            {
                var entry = dbContext.Entry(Book);
                // entry.Collection(b => b.Authors).Load();
                // entry.Reference(b=>b.Category).Load();
                viewModel.Id = Book.Id;
                viewModel.Category = viewModel.Categories.First(c => c.Id == Book.CategoryId);
                viewModel.Author = viewModel.Authors.First(a => a.Id == Book.Authors.First().Id);
                viewModel.Title = Book.Title;
                viewModel.ISBN = Book.ISBN;
            }
            base.OnActivated(e);
        }

        private void ViewModelOnOnSubmitSuccess(object? sender, EventArgs e)
        {
            if (Book == null)
                Book = new Book();
            Book.Id = viewModel.Id.Value;
            Book.Category = viewModel.Category;
            Book.Title = viewModel.Title;
            Book.ISBN = viewModel.ISBN;
            Book.Authors = new List<Author>() { viewModel.Author };
            DialogResult = true;
        }
    }
}
