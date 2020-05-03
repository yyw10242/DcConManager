using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;

using DcConManager.Windows;

namespace DcConManager
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
            Core.SplashPopup();
        }

        // No more use
        //public override void OnFrameworkInitializationCompleted()
        //{
        //    if (this.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        //    {
        //        desktop.MainWindow = Core.MainWindow;
        //        desktop.ShutdownMode = ShutdownMode.OnExplicitShutdown;
        //    }
        //    base.OnFrameworkInitializationCompleted();
        //}
    }
}
