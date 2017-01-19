using System.Collections.Generic;
using System.Windows;
<<<<<<< HEAD
using System.Windows.Documents;
=======
>>>>>>> d6ccff03039692c02479c0c7449a4b21393aec5f

namespace ItemTemplateExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// http://www.wpf-tutorial.com/wpf-application/resources/
    /// http://www.wpf-tutorial.com/listview-control/listview-data-binding-item-template/
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

        private void LvClick_Click(object sender, RoutedEventArgs e)
        {
            List<User> items = new List<User>()
            {
                new User(){ Name = "John Doe", Age = 42; }
            };
        }
    }

    internal class User
    {
    public int Age { get; internal set; }
    public string Name { get; internal set; }
    }

    internal class User
{
    public int Age { get; internal set; }
    public string Name { get; internal set; }
}
}
