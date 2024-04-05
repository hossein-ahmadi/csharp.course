using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using Demo120___WPFMVVM.Commands;

namespace Demo120___WPFMVVM.ViewModels;

public class PersonViewModel : INotifyPropertyChanged
{
    private string firstname;
    private string lastname;

    public string Firstname
    {
        get => firstname;
        set
        {
            firstname = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Firstname)));
        }
    }

    public string Lastname
    {
        get => lastname;
        set
        {
            lastname = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Lastname)));
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    private ICommand displayFullnameCommand;
    private ICommand changeValuesCommand;

    public ICommand DisplayFullnameCommand
    {
        get
        {
            return displayFullnameCommand ??= new CommandExecuter(() =>
            {
                MessageBox.Show($"{Firstname} {Lastname}");
            });
        }
    }

    public ICommand ChangeValuesCommand
    {
        get
        {
            return changeValuesCommand ??= new CommandExecuter(() =>
            {
                Firstname = "Alireza";
                Lastname = "Fazeli";
            });
        }
    }
}