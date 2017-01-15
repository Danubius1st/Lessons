using System.ComponentModel;

namespace MultipleViews.Models
{
    public class Customer : INotifyPropertyChanged, IDataErrorInfo
    {
        /// <summary>
        /// Initialize a new instance of the Customer class
        /// </summary>
        /// <param name="customerName"></param>
        public Customer(string customerName)
        {
            Name = customerName;
        }

        private string _name;

        /// <summary>
        /// Gets or sets the Customer's name
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        #region IDataErrorInfo Members

        public string Error
        {
            get;
            private set;
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "Name")
                {
                    if (string.IsNullOrWhiteSpace(columnName))
                    {
                        Error = "Name cannot be null or empty";
                    }
                    else
                    {
                        Error = null;
                    }
                }
                return Error;
            }
        }

        #endregion
    }
}
