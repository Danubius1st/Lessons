using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ItemTemplateExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // https://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k(System.Windows.Controls.ItemsControl.ItemTemplate);k(VS.XamlEditor);k(TargetFrameworkMoniker-.NETFramework,Version%3Dv4.5.2)&rd=true
            // http://www.wpf-tutorial.com/wpf-application/resources/
            InitializeComponent();

            string TaskName = "TaskName";
            string Description = "Description";
            string Priority = "Priority";
        }
    }
}
