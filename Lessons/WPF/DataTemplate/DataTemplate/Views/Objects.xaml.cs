using DataTemplate.Models;
using System.Collections.Generic;
using System.Windows.Controls;

namespace DataTemplate.Views
{
    public partial class Objects : UserControl
    {
        public Objects()
        {
            InitializeComponent();
            Loaded += Objects_Loaded;
        }

        private void Objects_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            List<object> list = new List<object> { "a", 1, "b", 2, new Todo() { Name = "Brian" }.ToString() };
            tv.DataContext = list;
        }
    }
}
