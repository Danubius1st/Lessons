using System.Windows;

namespace DependencyPropertyExample
{
    public class B : DependencyObject
    {
        public static readonly DependencyProperty HeightProperty;
        static B()
        {
            HeightProperty = A.HeightProperty.AddOwner(typeof(B), new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.Inherits));
        }

        public int Height
        {
            get { return (int)GetValue(HeightProperty); }
            set { SetValue(HeightProperty, value); }
        }
    }
}