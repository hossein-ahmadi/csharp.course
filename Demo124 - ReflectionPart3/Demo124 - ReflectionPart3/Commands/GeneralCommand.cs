using System.Windows.Input;

namespace Demo124___ReflectionPart3.Commands;

public class GeneralCommand : ICommand
{
    private readonly Action executeAction;
    private readonly Func<bool>? canExecute;

    public GeneralCommand(Action executeAction, Func<bool>? canExecute = null)
    {
        this.executeAction = executeAction;
        this.canExecute = canExecute;
    }

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
        add { CommandManager.RequerySuggested += value; }
        remove { CommandManager.RequerySuggested -= value; }
    }
}