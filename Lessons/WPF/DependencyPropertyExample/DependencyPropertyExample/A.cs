using System.Windows;

namespace DependencyPropertyExample
{
    public class A : DependencyObject
    {
        public int Height
        {
            get { return (int)GetValue(HeightProperty); }
            set { SetValue(HeightProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Height.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HeightProperty =
            DependencyProperty.Register("Height", typeof(int), typeof(A), new PropertyMetadata(0));

        public B BObject { get; set; }
    }
}
