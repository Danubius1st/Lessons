using System;
using System.Windows;
using System.Windows.Threading;

namespace DependencyPropertyExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // https://www.codeproject.com/Articles/140620/WPF-Tutorial-Dependency-Property
        // https://www.google.ro/url?sa=t&rct=j&q=&esrc=s&source=web&cd=1&cad=rja&uact=8&ved=0ahUKEwi63LC_xdDRAhUGC8AKHUDZC4YQtwIIGjAA&url=https%3A%2F%2Fwww.youtube.com%2Fwatch%3Fv%3DgtAryodSiME&usg=AFQjCNEMAoJGhk9ArACuHVTt386CYtIJew&sig2=gyGyWdcST-ha5aiVD_-OTw
        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer(TimeSpan.FromSeconds(1), DispatcherPriority.Normal,
                delegate
                {
                    int newvalue = 0;
                    if (Counter == int.MaxValue)
                    {
                        newvalue = 0;
                    }
                    else
                    {
                        newvalue = Counter + 1;
                    }
                    SetValue(CounterProperty, newvalue);
                }, Dispatcher);
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



        public int Counter
        {
            get { return (int)GetValue(CounterProperty); }
            set { SetValue(CounterProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Counter.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CounterProperty =
            DependencyProperty.Register("Counter", typeof(int), typeof(MainWindow), new PropertyMetadata(20));


    }
}
