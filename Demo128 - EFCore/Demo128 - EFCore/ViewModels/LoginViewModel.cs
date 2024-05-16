using System.Windows;
using Demo128___EFCore.Base;
using System.Windows.Input;
using Demo128___EFCore.DbModel;

namespace Demo128___EFCore.ViewModels;

public class LoginViewModel(ApplicationDbContext dbContext) : ViewModelBase
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


    private void LoginCommandAction()
    {
        var user = dbContext.Users.FirstOrDefault(u => u.Username == Username);
        if (user == null || user.Password != Password)
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