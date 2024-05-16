using System.Windows.Input;

namespace Demo128___EFCore.Commands;

public class GeneralCommand(Action executeAction, Func<bool>? canExecute = null) : ICommand
{
    public bool CanExecute(object? parameter)
    {
        return canExecute?.Invoke() ?? true;
    }

    public void Execute(object? parameter)
    {
        executeAction();
    }

    public event EventHandler? CanExecuteChanged
    {
        add => CommandManager.RequerySuggested += value;
        remove => CommandManager.RequerySuggested -= value;
    }
}