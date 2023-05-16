using CommunityToolkit.Mvvm.Input;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace BubblingEventsDemo.UI
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private ICommand? _ButtonClickedCommand;
        public ICommand ButtonClickedCommand
        {
            get
            {
                if (_ButtonClickedCommand == null)
                    _ButtonClickedCommand = new RelayCommand(ButtonClickedExecuted, ButtonClickedCanExecute);
                return _ButtonClickedCommand;
            }
        }

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private bool ButtonClickedCanExecute()
        {
            return true;
        }

        private void ButtonClickedExecuted()
        {
        }
    }
}
