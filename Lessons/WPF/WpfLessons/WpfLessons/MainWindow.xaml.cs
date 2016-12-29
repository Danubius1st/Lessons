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

namespace WpfLessons
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //GridSplitter mySimpleGridSplitter = new GridSplitter();
            //Grid.SetColumn(mySimpleGridSplitter, 0);
            //mySimpleGridSplitter.Background = Brushes.Blue;
            //mySimpleGridSplitter.HorizontalAlignment = HorizontalAlignment.Right;
            //mySimpleGridSplitter.VerticalAlignment = VerticalAlignment.Stretch;
            //mySimpleGridSplitter.Width = 5;
        }
    }
}
