using CommunityToolkit.Mvvm.Input;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace BubblingEventsDemo
{
    public class InnerControl : Control
    {
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

        public static readonly RoutedEvent ButtonClickedEvent =
                    EventManager.RegisterRoutedEvent("ButtonClicked",
                    RoutingStrategy.Bubble,
                    typeof(RoutedEventHandler),
                    typeof(InnerControl));


        public event RoutedEventHandler ButtonClicked
        {
            add { AddHandler(ButtonClickedEvent, value); }
            remove { RemoveHandler(ButtonClickedEvent, value); }
        }

        static InnerControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(InnerControl),
                new FrameworkPropertyMetadata(typeof(InnerControl)));
        }

        private bool ButtonClickedCanExecute()
        {
            return true;
        }

        private void ButtonClickedExecuted()
        {
            var args = new RoutedEventArgs(ButtonClickedEvent);
            RaiseEvent(args);
        }
    }
}
