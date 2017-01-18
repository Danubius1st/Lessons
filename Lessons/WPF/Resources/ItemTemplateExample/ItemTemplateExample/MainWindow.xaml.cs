using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;

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

            List<User> items = new List<User>()
            {
                new User(){ Name = "John Doe", Age = 42; }
            };
        }

        private void BtnClickMe_Click(object sender, RoutedEventArgs e)
        {
            lbResult.Items.Add(pnlMain.FindResource("strPanel").ToString());
            lbResult.Items.Add(pnlMain.FindResource("strHelloWorld").ToString());
            lbResult.Items.Add(Application.Current.FindResource("strApp").ToString());
        }
    }

    internal class User
{
    public int Age { get; internal set; }
    public string Name { get; internal set; }
}
}
