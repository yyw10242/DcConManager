using DcConManager.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DcConManager
{
    public static class Core
    {
        private static MainWindow _mainWindow;
        public static MainWindow MainWindow => Core._mainWindow ?? (Core._mainWindow = new MainWindow());

        public static void Start()
        {
            Core.MainWindow.Show();
        }
    }
}
