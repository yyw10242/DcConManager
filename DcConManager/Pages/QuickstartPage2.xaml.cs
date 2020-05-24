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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DcConManager.Pages
{
    public partial class QuickstartPage2 : Page
    {
        public QuickstartPage2()
        {
            this.InitializeComponent();
        }

        private void PrevButton_Click(object sender, RoutedEventArgs e) => Core.QuickstartManager.GoPrev();
        private void NextButton_Click(object sender, RoutedEventArgs e) => Core.QuickstartManager.GoNext();
    }
}
