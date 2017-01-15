using MultipleViews.Models;
using MultipleViews.Commands;
using System.Windows.Input;
using MultipleViews.Views;

namespace MultipleViews.ViewModels
{
    internal class CustomerViewModel
    {
        private readonly Customer _Customer;
        private readonly CustomerInfoViewModel _ChildViewModel;

        public Customer Customer
        {
            get { return _Customer; }
        }

        public ICommand UpdateCommand { get; private set; }

        public CustomerViewModel()
        {
            _Customer = new Customer("David");
            _ChildViewModel = new CustomerInfoViewModel()
            {
                Info = "Instantiated in CustomerViewModel() ctor."
            };

            UpdateCommand = new UpdateCustomerCommand(this);
        }

        public void SaveChanges()
        {
            CustomerInfoView view = new CustomerInfoView();
            view.DataContext = _ChildViewModel;

            //_ChildViewModel.Info = Customer.Name + " was updated in the database.";

            view.ShowDialog();
        }
    }
}
