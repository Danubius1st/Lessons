using System;
using System.Windows;

namespace DependencyPropertyExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // https://www.codeproject.com/Articles/140620/WPF-Tutorial-Dependency-Property
        public MainWindow()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty IsValuePassedProperty = DependencyProperty.RegisterAttached("IsValuePassed", typeof(bool), typeof(MainWindow), new FrameworkPropertyMetadata(new PropertyChangedCallback(IsValuePassed_Changed)));

        private static void IsValuePassed_Changed(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            MessageBox.Show("Value Passed: " + e.OldValue + " => " + e.NewValue);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SetIsValuePassed(this, !(bool)GetValue(IsValuePassedProperty));
        }

        public static void SetIsValuePassed(DependencyObject d, bool value)
        {
            d.SetValue(IsValuePassedProperty, value);
        }

        public static bool GetIsValuePassed(DependencyObject d)
        {
            return (bool)d.GetValue(IsValuePassedProperty);
        }
    }
}
