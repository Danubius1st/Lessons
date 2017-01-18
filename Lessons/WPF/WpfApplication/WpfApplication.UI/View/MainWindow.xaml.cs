using System.Windows;
using WpfApplication.UI.ViewModel;

namespace WpfApplication.UI.View
{
    public partial class MainWindow : Window
    {
        private readonly MainViewModel _viewModel;

        public MainWindow(MainViewModel viewModel)
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;

            DataContext = _viewModel = viewModel;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            _viewModel.Load();
        }
    }
}
