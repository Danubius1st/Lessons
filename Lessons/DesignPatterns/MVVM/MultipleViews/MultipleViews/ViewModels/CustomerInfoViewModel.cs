using System.ComponentModel;

namespace MultipleViews.ViewModels
{
    internal class CustomerInfoViewModel : INotifyPropertyChanged
    {
        private string _Info;

        public string Info
        {
            get { return _Info; }
            set
            {
                _Info = value;
                OnPropertyChanged("Info");
            }
        }
        
        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
