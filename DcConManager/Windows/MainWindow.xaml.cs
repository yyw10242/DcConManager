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
    public partial class MainWindow : BaseWindow
    {
        public MainWindow()
        {
            this.InitializeComponent();

            this.SetImages();

            this.QuickStartFrame.Content = Core.QuickstartPage1;
        }

        private void SetImages()
        {
            (this.Button0.Icon as Image).SetBitmap(DcConManager.Properties.Resources.QuickStartImage);
            (this.Button1.Icon as Image).SetBitmap(DcConManager.Properties.Resources.StartManagerImage);
            (this.Button2.Icon as Image).SetBitmap(DcConManager.Properties.Resources.BridgeBBDDSettingsImage);
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            this.QuickStartFlyout.IsOpen = !this.QuickStartFlyout.IsOpen;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
