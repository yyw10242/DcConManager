using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DcConManager.Controls
{
    public partial class MetroWindowCommandButton : Button
    {
        public UIElement Icon
        {
            get { return GetValue(IconProperty) as UIElement; }
            set { SetValue(IconProperty, value); }
        }

        public static readonly DependencyProperty IconProperty = DependencyProperty.Register(
            "Icon",
            typeof(UIElement),
            typeof(MetroWindowCommandButton));

        public string Text
        {
            get { return GetValue(TextProperty) as string; }
            set { SetValue(TextProperty, value); }
        }

        public static readonly DependencyProperty TextProperty = DependencyProperty.Register(
            "Text",
            typeof(string),
            typeof(MetroWindowCommandButton));

        public new double FontSize
        {
            get => this.TextBlock.FontSize;
            set
            {
                if (this.TextBlock.FontSize == value) return;

                this.TextBlock.FontSize = value;
            }
        }

        public MetroWindowCommandButton()
        {
            this.InitializeComponent();
            this.FontSize = 12;
        }
    }
}
