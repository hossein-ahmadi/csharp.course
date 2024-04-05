using System.Windows.Input;

namespace Demo120___WPFMVVM.Commands;

public class CommandExecuter : ICommand
{
    private Func<bool>? canExecute;
    private Action action;

    public CommandExecuter(Action action, Func<bool>? canExecute = null)
    {
        this.canExecute = canExecute;
        this.action = action;
    }

    public bool CanExecute(object? parameter)
    {
        return canExecute?.Invoke() ?? true;
    }

    public void Execute(object? parameter)
    {
        action();
    }

    public event EventHandler? CanExecuteChanged;
}