using System.Windows;
using Demo128___EFCore.DbModel.Entities;
using Demo128___EFCore.ViewModels.Authors;
using Demo128___EFCore.ViewModels.BookCategories;

namespace Demo128___EFCore.Views.BookCategories
{
    /// <summary>
    /// Interaction logic for AuthorEditor.xaml
    /// </summary>
    public partial class BookCategoryEditor : Window
    {
        private readonly BookCategoryEditorViewModel viewModel;
        public DbModel.Entities.BookCategory? BookCategory { get; set; }

        public BookCategoryEditor(BookCategoryEditorViewModel viewModel)
        {
            this.viewModel = viewModel;
            this.DataContext = viewModel;
            viewModel.OnSubmitChangesSuccess += OnSubmitChangesSuccess;
            this.viewModel = viewModel;
            InitializeComponent();
        }


        private void OnSubmitChangesSuccess(object? sender, EventArgs e)
        {
            if (BookCategory == null)
                BookCategory = new BookCategory();
            BookCategory.Id = viewModel.Id ?? 0;
            BookCategory.Title = viewModel.Title;
            DialogResult = true;
        }

        protected override void OnActivated(EventArgs e)
        {
            if (BookCategory != null)
            {
                this.Title = "ویرایش دسته بندی کتاب";
                this.viewModel.Id = BookCategory.Id;
                this.viewModel.Title = BookCategory.Title;
            }
            else
            {
                this.Title = "تعریف دسته بندی جدید";
            }
            base.OnActivated(e);
        }
    }
}
