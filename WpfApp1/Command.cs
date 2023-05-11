using System;
using System.Windows.Input;

namespace WpfApp1
{
    public class Command<T> : ICommand  where T : class 
    {
        public Action<T> ExceuteAction { get; }
        public Predicate<T>? CanexceuteAction { get; }

        public event EventHandler? CanExecuteChanged;

        public Command(Action<T> exceuteAction, Predicate<T>? canexceuteAction = null)
        {
            ExceuteAction = exceuteAction;
            CanexceuteAction = canexceuteAction;
        }

        public bool CanExecute(object? parameter) => CanexceuteAction == null || CanexceuteAction.Invoke((T)parameter);

        public void Execute(object? parameter) => ExceuteAction.Invoke((T)parameter);
    }

}
