using DataTemplate.Models;
using System.Collections.Generic;
using System.Windows.Controls;

namespace DataTemplate.Views
{
    public partial class Obs : UserControl
    {
        public Obs()
        {
            InitializeComponent();
            Loaded += Obs_Loaded;
        }

        private void Obs_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            List<Todo> myTodoList = new List<Todo>()
            {
                new Todo() { Name = "Shopping", Description = "Pick up Groceries and Detergent", Priority = 2 },
                new Todo() { Name = "Laundry", Description = "Do my Laundry", Priority = 2 },
                new Todo() { Name = "Email", Description = "Email clients", Priority = 1 },
                new Todo() { Name = "Clean", Description = "Clean my office", Priority = 3 }
            };
            lvObs.ItemsSource = myTodoList;
        }
    }
}
