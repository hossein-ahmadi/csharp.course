using Demo128___EFCore.Base;
using Demo128___EFCore.DbModel;
using Demo128___EFCore.DbModel.Entities;
using System.Windows;
using System.Windows.Input;

namespace Demo128___EFCore.ViewModels.Authors;

public class AuthorEditorViewModel : ViewModelBase
{
    private readonly ApplicationDbContext dbContext;

    public event EventHandler OnSubmitChangesSuccess;

    public AuthorEditorViewModel(ApplicationDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    private string name;
    private int? id;


    public int? Id
    {
        get => id;
        set => SetProperty(ref id, value);
    }

    public string Name
    {
        get => name;
        set => SetProperty(ref name, value);
    }

    public ICommand AcceptChangesCommand => ResolveCommand("Authors.Editor.AcceptChanges", ExecuteSubmitChanges);

    private void ExecuteSubmitChanges()
    {
        if (!ValidateInputs())
        {
            return;
        }
        Author author;
        if (Id.HasValue)
            author = dbContext.Authors.Find(Id);
        else
        {
            author = new Author();
            dbContext.Authors.Add(author);
        }
        author.Name = Name;
        dbContext.SaveChanges();
        Id = author.Id;
        OnSubmitChangesSuccess?.Invoke(this, EventArgs.Empty);
    }

    private bool ValidateInputs()
    {
        if (string.IsNullOrEmpty(Name))
        {
            MessageBox.Show("نام را به صورت کامل وارد کنید.");
            return false;
        }

        if (!Id.HasValue && dbContext.Authors.Any(m => m.Name == Name))
        {
            MessageBox.Show("نام وارد شده قبلاً در سیستم ثبت شده است");
            return false;
        }
        return true;
    }
}