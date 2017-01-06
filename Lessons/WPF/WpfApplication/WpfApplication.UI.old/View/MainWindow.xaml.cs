using System;
using System.Windows;
using WpfApplication.ViewModel;

namespace WpfApplication.View
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

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            _viewModel.Load();
        }
    }
}
