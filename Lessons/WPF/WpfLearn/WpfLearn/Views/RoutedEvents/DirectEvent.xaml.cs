using System.Windows;

namespace WpfLearn.Views.RoutedEvents
{
    /// <summary>
    /// Interaction logic for DirectEvent.xaml
    /// </summary>
    public partial class DirectEvent : Window
    {
        public DirectEvent()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txt1.Text = "Button is Clicked";
        }

        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            txt2.Text = "Click event is bubbled to Stack Panel";
            e.Handled = true; //stop the routed event
        }

        private void Window_Click(object sender, RoutedEventArgs e)
        {
            txt3.Text = "Click event is bubbled to Window";
        }
    }
}
