using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public NavigationViewModel NavigationViewModel { get; private set; }

        public MainViewModel()
        {
            NavigationViewModel = new NavigationViewModel();
        }

        internal void Load()
        {
            NavigationViewModel.Load();
        }
    }
}
