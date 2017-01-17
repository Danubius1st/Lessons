using System.Windows;
using System.Windows.Controls;

namespace WpfLearn.Views
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty SetTextProperty =
         DependencyProperty.Register("SetText", typeof(string), typeof(UserControl1), new
            PropertyMetadata("", OnSetTextChanged));

        public string SetText
        {
            get { return (string)GetValue(SetTextProperty); }
            set { SetValue(SetTextProperty, value); }
        }

        private static void OnSetTextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            UserControl1 userControl1Control = d as UserControl1;
            if (userControl1Control != null) userControl1Control.OnSetTextChanged(e);
        }
        private void OnSetTextChanged(DependencyPropertyChangedEventArgs e)
        {
            tbTest.Text = e.NewValue.ToString();
        }
    }
}
