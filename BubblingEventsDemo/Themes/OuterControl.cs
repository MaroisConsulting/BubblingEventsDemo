using System.Windows;
using System.Windows.Controls;

namespace BubblingEventsDemo
{
    public class OuterControl : UserControl
    {
        static OuterControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(OuterControl),
                new FrameworkPropertyMetadata(typeof(OuterControl)));
        }
    }
}
