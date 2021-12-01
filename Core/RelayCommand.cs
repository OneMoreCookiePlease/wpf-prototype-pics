using System;
using System.Windows.Input;

namespace Pics
{
    class RelayCommand : ICommand
    {
        private Action<object> execute;
        private Func<object, bool> canExecute;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }

        }

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;

        }


        public bool CanExecute(object paremeter)
        {
            return canExecute == null || this.CanExecute(paremeter);
        }
        public void Execute(object parameter)
        {
            this.execute(parameter);
        }


    }
}
