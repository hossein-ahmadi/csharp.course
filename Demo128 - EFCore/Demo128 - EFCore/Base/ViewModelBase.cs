using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Demo128___EFCore.Commands;

namespace Demo128___EFCore.Base;

public abstract class ViewModelBase : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    private Dictionary<string, GeneralCommand> createdCommands = new();

    protected void SetProperty<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        field = value;
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected ICommand ResolveCommand(string key, Action executeAction, Func<bool>? canExecute = null)
    {
        if (createdCommands.ContainsKey(key))
            return createdCommands[key];

        var newCommand = new GeneralCommand(executeAction, canExecute);
        createdCommands.Add(key, newCommand);
        return newCommand;
    }
}