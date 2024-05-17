using System.Windows;
using Demo128___EFCore.Base;
using System.Windows.Input;
using Demo128___EFCore.DbModel;
using Demo128___EFCore.Services;

namespace Demo128___EFCore.ViewModels;

public class LoginViewModel(ApplicationDbContext dbContext, MembershipServices membership) : ViewModelBase
{
    private string? username;
    private string? password;

    public event EventHandler? OnSuccessLogin;

    public string? Username
    {
        get => username;
        set => SetProperty(ref username, value);
    }

    public string? Password
    {
        get => password;
        set => SetProperty(ref password, value);
    }

    public ICommand? LoginCommand => ResolveCommand("LoginCommand", LoginCommandAction, LoginCommandValidator);


    private async void LoginCommandAction()
    {
        if (!(await membership.UserIsValidAsync(Username, Password)))
        {
            MessageBox.Show("نام کاربری یا کلمه عبور صحیح نمی باشد");
            return;
        }

        if (OnSuccessLogin != null)
        {
            OnSuccessLogin(this, EventArgs.Empty);
        }
    }

    private bool LoginCommandValidator()
    {
        return !string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password);
    }
}