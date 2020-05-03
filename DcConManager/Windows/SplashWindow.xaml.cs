using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace DcConManager.Windows
{
    public class SplashWindow : Window
    {
        public SplashWindow()
        {
            this.InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif

            this.PointerPressed += SplashWindow_PointerPressed;
            this.PointerReleased += SplashWindow_PointerReleased;
        }

        private void SplashWindow_PointerPressed(object sender, PointerPressedEventArgs e)
        {
            this.BeginMoveDrag(e);
        }

        private void SplashWindow_PointerReleased(object sender, PointerReleasedEventArgs e)
        {
            //this.EndMoveDrag(e);
        }

        private void CloseButtonClick(object sender, RoutedEventArgs e)
        {
            Core.StartUp();
            this.Close();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
