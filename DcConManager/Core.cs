using System;
using System.Collections.Generic;
using System.Text;

using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;

using DcConManager.Windows;


namespace DcConManager
{
    public static partial class Core
    {
        public static void SplashPopup()
        {
            Core.SplashWindow.Show();
        }

        public static void StartUp()
        {
            if (App.Current.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = Core.MainWindow;
                desktop.ShutdownMode = ShutdownMode.OnMainWindowClose;
            }

            Core.MainWindow.Show();
        }
    }
}
