using System;
using System.Windows.Input;
using MultipleViews.ViewModels;

namespace MultipleViews.Commands
{
    internal class UpdateCustomerCommand : ICommand
    {
        private CustomerViewModel _ViewModel;

        public UpdateCustomerCommand(CustomerViewModel viewModel)
        {
            _ViewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public bool CanExecute(object parameter)
        {
            return string.IsNullOrWhiteSpace(_ViewModel.Customer.Error);
        }

        public void Execute(object parameter)
        {
            _ViewModel.SaveChanges();
        }
    }
}
