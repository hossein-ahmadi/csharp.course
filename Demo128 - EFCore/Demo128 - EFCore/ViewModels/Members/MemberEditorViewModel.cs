using System.Windows;
using System.Windows.Input;
using Demo128___EFCore.Base;
using Demo128___EFCore.DbModel;
using Demo128___EFCore.DbModel.Entities;

namespace Demo128___EFCore.ViewModels.Members;

public class MemberEditorViewModel : ViewModelBase
{
    private readonly ApplicationDbContext dbContext;

    public event EventHandler OnSubmitChangesSuccess;

    public MemberEditorViewModel(ApplicationDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    private int? id;
    private string nationalCode;
    private string firstname;
    private string lastname;
    private string mobile;

    public int? Id
    {
        get => id;
        set => SetProperty(ref id, value);
    }

    public string NationalCode
    {
        get => nationalCode;
        set => SetProperty(ref nationalCode, value);
    }

    public string Firstname
    {
        get => firstname;
        set => SetProperty(ref firstname, value);
    }

    public string Lastname
    {
        get => lastname;
        set => SetProperty(ref lastname, value);
    }

    public string Mobile
    {
        get => mobile;
        set => SetProperty(ref mobile, value);
    }

    public ICommand AcceptChangesCommand => ResolveCommand("Members.Editor.AcceptChanges", ExecuteSubmitChanges);

    private void ExecuteSubmitChanges()
    {
        if (!ValidateInputs())
        {
            return;
        }
        Member member;
        if (Id.HasValue)
            member = dbContext.Members.Find(Id);
        else
        {
            member = new Member();
            member.RegistryDate = DateTime.Now;
            dbContext.Members.Add(member);
        }
        member.NationalCode = NationalCode;
        member.Firstname = Firstname;
        member.Lastname = Lastname;
        member.Mobile = Mobile;
        dbContext.SaveChanges();
        Id = member.Id;
        OnSubmitChangesSuccess?.Invoke(this, EventArgs.Empty);
    }

    private bool ValidateInputs()
    {
        if (string.IsNullOrEmpty(NationalCode) || NationalCode.Length < 10)
        {
            MessageBox.Show("کد ملی باید به صورت صحیح وارد شود");
            return false;
        }

        if (!Id.HasValue && dbContext.Members.Any(m=>m.NationalCode == NationalCode))
        {
            MessageBox.Show("کد ملی وارد شده قبلاً ثبت شده است!");
            return false;
        }

        if (Id.HasValue && dbContext.Members.Any(m => m.Id != Id && m.NationalCode == NationalCode))
        {
            MessageBox.Show("کد ملی وارد شده قبلاً ثبت شده است!");
            return false;
        }
        return true;
    }
}