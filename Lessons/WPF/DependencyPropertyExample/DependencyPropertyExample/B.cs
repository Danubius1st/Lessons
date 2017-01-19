using System.Windows;

namespace DependencyPropertyExample
{
    public class B : DependencyObject
    {
        public static readonly DependencyProperty HeightProperty;
        public B()
        {
            HeightProperty = A.HeightProperty.AddOwner(typeof(B), new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.Inherits))
        }
    }
}