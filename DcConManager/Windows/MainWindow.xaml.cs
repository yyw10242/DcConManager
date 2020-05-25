using System;
using System.ComponentModel;
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
using MahApps.Metro.Controls.Dialogs;

using DcConManager.Utilities.ExtendedMethods;

namespace DcConManager.Windows
{
    public partial class MainWindow : BaseWindow
    {
        public MainWindow()
        {
            this.InitializeComponent();

            this.SetImages();

            
        }

        private void BaseWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Core.QuickstartManager.Reset();
        }

        private void BaseWindow_Closing(object sender, CancelEventArgs e)
        {
            this.AskCloseAsync(sender, e);
        }

        private void SetImages()
        {
            (this.Button0.Icon as Image).SetBitmap(DcConManager.Properties.Resources.QuickStartImage);
            (this.Button1.Icon as Image).SetBitmap(DcConManager.Properties.Resources.StartManagerImage);
            (this.Button2.Icon as Image).SetBitmap(DcConManager.Properties.Resources.BridgeBBDDSettingsImage);
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            this.QuickstartFlyout.IsOpen = !this.QuickstartFlyout.IsOpen;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {

        }

        private async void AskCloseAsync(object sender, CancelEventArgs e)
        {
            e.Cancel = true;

            MessageDialogResult result = await this.ShowMessageAsync("종료", "정말 DcConManager를 종료할까요?",
                MessageDialogStyle.AffirmativeAndNegative,
                new MetroDialogSettings()
                {
                    DialogMessageFontSize = 12,

                    AffirmativeButtonText = "종료",
                    NegativeButtonText = "취소",
                });

            if (result == MessageDialogResult.Affirmative)
            {
                Core.Exit();
            }
        }

        private void TitlebarHomeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Title += "홈";
        }
    }
}
