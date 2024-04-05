using System.ComponentModel;
using Demo121___DotNetConfigurationAndDI.Services.Abstracts;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Demo121___DotNetConfigurationAndDI.ViewModels;

public class PersonViewModel : INotifyPropertyChanged
{
    public PersonViewModel(IPersonRepository repository)
    {
        var person = repository.GetPerson(12);
        this.Firstname = person.Firstname;
        this.Lastname = person.Lastname;
    }

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
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(lastname)));
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
}