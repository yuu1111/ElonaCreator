using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;



namespace ElonaCreator
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion



        #region ICommand Helper
        private class DelegateCommand : ICommand
        {
            private Action<object> _Command;
            private Func<object, bool> _CanExecute;

            public DelegateCommand(Action<object> command, Func<object, bool> canExecute = null)
            {
                _Command = command ?? throw new ArgumentNullException();
                _CanExecute = canExecute;
            }

            void ICommand.Execute(object parameter)
            {
                _Command(parameter);
            }

            bool ICommand.CanExecute(object parameter)
            {
                if (_CanExecute != null)
                    return _CanExecute(parameter);
                else
                    return true;
            }

            event EventHandler ICommand.CanExecuteChanged
            {
                add { CommandManager.RequerySuggested += value; }
                remove { CommandManager.RequerySuggested -= value; }
            }
        }


        protected ICommand CreateCommand(Action<object> command, Func<object, bool> canExecute = null)
        {
            return new DelegateCommand(command, canExecute);
        }
        #endregion
    }
}