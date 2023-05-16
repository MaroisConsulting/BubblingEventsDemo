using System.Windows;

namespace BubblingEventsDemo.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindowView : Window
    {
        public MainWindowView()
        {
            InitializeComponent();

            this.DataContext = new MainWindowViewModel();
        }

        private void OuterControl_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
