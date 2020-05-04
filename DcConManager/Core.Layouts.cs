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
        private static SplashWindow _splashWindow;
        public static SplashWindow SplashWindow => Core._splashWindow ?? (Core._splashWindow = new SplashWindow());

        private static MainWindow _mainWindow;
        public static MainWindow MainWindow => Core._mainWindow ?? (Core._mainWindow = new MainWindow());
    }
}
