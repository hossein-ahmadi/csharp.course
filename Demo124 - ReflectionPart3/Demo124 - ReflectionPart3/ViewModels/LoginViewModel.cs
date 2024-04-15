using System.Windows;
using System.Windows.Input;
using Demo124___ReflectionPart3.Commands;
using Demo124___ReflectionPart3.DataAccess.SqlServer;

namespace Demo124___ReflectionPart3.ViewModels;

public class LoginViewModel : ViewModelBase
{
    private readonly UsersRepository repository;

    public LoginViewModel(UsersRepository repository)
    {
        this.repository = repository;
    }

    private string username;
    private string password;

    public string Username
    {
        get => username;
        set => SetProperty(ref username, value);
    }

    public string Password
    {
        get => password;
        set => SetProperty(ref password, value);
    }

    private ICommand? loginCommand;

    public ICommand LoginCommand => loginCommand ??= new GeneralCommand(() =>
    {
        var user = repository.GetByUsername(Username);
        if (user != null && user.Password.Equals(Password))
        {
            MessageBox.Show("به برنامه حسابداری خوش آمدید");
        }
        else
        {
            MessageBox.Show("نام کاربری یا کلمه عبور اشتباه است.");
        }
    }, () => !string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password));
}