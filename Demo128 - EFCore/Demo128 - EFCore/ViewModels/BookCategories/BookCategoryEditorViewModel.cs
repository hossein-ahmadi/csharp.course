using Demo128___EFCore.Base;
using Demo128___EFCore.DbModel;
using Demo128___EFCore.DbModel.Entities;
using System.Windows;
using System.Windows.Input;

namespace Demo128___EFCore.ViewModels.BookCategories;

public class BookCategoryEditorViewModel : ViewModelBase
{
    private readonly ApplicationDbContext dbContext;

    public event EventHandler OnSubmitChangesSuccess;

    public BookCategoryEditorViewModel(ApplicationDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    private string tile;
    private int? id;


    public int? Id
    {
        get => id;
        set => SetProperty(ref id, value);
    }

    public string Title
    {
        get => tile;
        set => SetProperty(ref tile, value);
    }

    public ICommand AcceptChangesCommand => ResolveCommand("BookCategories.Editor.AcceptChanges", ExecuteSubmitChanges);

    private void ExecuteSubmitChanges()
    {
        if (!ValidateInputs())
        {
            return;
        }
        BookCategory bookCategory;
        if (Id.HasValue)
            bookCategory = dbContext.BookCategories.Find(Id);
        else
        {
            bookCategory = new BookCategory();
            dbContext.BookCategories.Add(bookCategory);
        }
        bookCategory.Title = Title;
        dbContext.SaveChanges();
        Id = bookCategory.Id;
        OnSubmitChangesSuccess?.Invoke(this, EventArgs.Empty);
    }

    private bool ValidateInputs()
    {
        if (string.IsNullOrEmpty(Title))
        {
            MessageBox.Show("عنوان را به صورت کامل وارد کنید.");
            return false;
        }

        if (!Id.HasValue && dbContext.BookCategories.Any(m => m.Title == Title))
        {
            MessageBox.Show("عنوان وارد شده قبلاً در سیستم ثبت شده است");
            return false;
        }
        return true;
    }
}