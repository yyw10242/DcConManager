using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        //private static Page _currentPage;
        //public static Page CurrentPage => Core._currentPage ?? (Core._currentPage = Core.QuickstartPage1);

        private static Page _quickstartPage1;
        public static Page QuickstartPage1 => Core._quickstartPage1 ?? (Core._quickstartPage1 = new QuickstartPage1());

        private static Page _quickstartPage2;
        public static Page QuickstartPage2 => Core._quickstartPage2 ?? (Core._quickstartPage2 = new QuickstartPage2());

        public static void Start()
        {
            Core.MainWindow.Show();
        }
    }
}
