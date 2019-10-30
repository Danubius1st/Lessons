using DataTemplate.Models;
using System;
using System.Collections.ObjectModel;

namespace DataTemplate.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<Todo> TaskList { get; set; }

        public MainViewModel()
        {
            LoadObs();
        }

        private void LoadObs()
        {
            //ObservableCollection<Todo> myTodoList = new ObservableCollection<Todo>()
            //{
            //    new Todo() { Name = "Shopping", Description = "Pick up Groceries and Detergent", Priority = 2 },
            //    new Todo() { Name = "Laundry", Description = "Do my Laundry", Priority = 2 },
            //    new Todo() { Name = "Email", Description = "Email clients", Priority = 1 },
            //    new Todo() { Name = "Clean", Description = "Clean my office", Priority = 3 }
            //};
            //TaskList = myTodoList;
        }
    }
}
