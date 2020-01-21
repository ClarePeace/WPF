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

namespace WpfApp1.L004
{
    /// <summary>
    /// WindowFrameAddPage.xaml 的交互逻辑
    /// </summary>
    public partial class WindowFrameAddPage : Window
    {
        public WindowFrameAddPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.FrameA.Source = new Uri("Page1.xaml", UriKind.RelativeOrAbsolute);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.FrameA.Source = new Uri("Page2.xaml", UriKind.RelativeOrAbsolute);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.FrameA.Source = new Uri("Page3.xaml", UriKind.RelativeOrAbsolute);
        }
    }
}
