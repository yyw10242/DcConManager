using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

using DcConManager.Pages;
using DcConManager.Windows;

namespace DcConManager
{
    public static class Core
    {
        //// Layouts
        private static MainWindow _mainWindow;
        public static MainWindow MainWindow => Core._mainWindow ?? (Core._mainWindow = new MainWindow());

        private static QuickstartManager _quickstartManager;
        public static QuickstartManager QuickstartManager => Core._quickstartManager ?? (Core._quickstartManager = new QuickstartManager());

        public static void Start()
        {
            Core.MainWindow.Show();
        }

        public static void Exit()
        {
            Application.Current.Shutdown();
        }
    }
}
