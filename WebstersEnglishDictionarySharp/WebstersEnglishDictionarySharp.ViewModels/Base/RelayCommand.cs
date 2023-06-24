using System;
using System.Windows.Input;

namespace WebstersEnglishDictionarySharp.ViewModels.Base
{
    public class RelayCommand : ICommand
    {
        private readonly Action<object> _commandToExecute;
        private readonly Func<object, bool> _canExecute;

        public RelayCommand(Action<object> commandToExecute, Func<object, bool> canExecute)
        {
            _commandToExecute = commandToExecute;
            _canExecute = canExecute;
        }

        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object? parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        public void Execute(object? parameter)
        {
            _commandToExecute(parameter);
        }
    }
}
