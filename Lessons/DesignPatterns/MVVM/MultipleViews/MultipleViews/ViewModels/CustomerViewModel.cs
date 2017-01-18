using System.Diagnostics;
using MultipleViews.Models;
using MultipleViews.Commands;
using System.Windows.Input;
using MultipleViews.Views;

namespace MultipleViews.ViewModels
{
    internal class CustomerViewModel
    {
    /// <summary>
    /// Initializes a new instance of the CustomerViewModel
    /// </summary>
        public CustomerViewModel()
        {
            _customer = new Customer("David");
            _ChildViewModel = new CustomerInfoViewModel()
            {
                Info = "Instantiated in CustomerViewModel() ctor."
            };

            UpdateCommand = new UpdateCustomerCommand(this);
        }

        private Customer _customer;

        /// <summary>
        /// Gets the customer instance
        /// </summary>
        public Customer Customer
        {
            get { return _customer; }
        }

        private CustomerInfoViewModel _ChildViewModel;
        public ICommand UpdateCommand { get; private set; }

        public void SaveChanges()
        {
            Debug.Assert(false, string.Format($"{Customer.Name} was update"));
            CustomerInfoView view = new CustomerInfoView();
            view.DataContext = _ChildViewModel;

            //_ChildViewModel.Info = Customer.Name + " was updated in the database.";

            view.ShowDialog();
        }
    }
}
