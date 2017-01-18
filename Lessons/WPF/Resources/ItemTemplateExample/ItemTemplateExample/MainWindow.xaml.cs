using System.Windows;

namespace ItemTemplateExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnClickMe_Click(object sender, RoutedEventArgs e)
        {
            lbResult.Items.Add(pnlMain.FindResource("strPanel").ToString());
            lbResult.Items.Add(pnlMain.FindResource("strHelloWorld").ToString());
            lbResult.Items.Add(Application.Current.FindResource("strApp").ToString());
        }
    }
}
