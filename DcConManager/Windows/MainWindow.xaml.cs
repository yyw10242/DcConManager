using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using MahApps.Metro.Controls;

using DcConManager.Utilities.ExtendedMethods;

namespace DcConManager.Windows
{
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            this.InitializeComponent();

            this.SetImages();
        }

        private void SetImages()
        {
            this.Image0.SetBitmap(DcConManager.Properties.Resources.QuickStartImage);
            this.Image1.SetBitmap(DcConManager.Properties.Resources.StartManagerImage);
            this.Image2.SetBitmap(DcConManager.Properties.Resources.BridgeBBDDSettingsImage);
        }
    }
}
