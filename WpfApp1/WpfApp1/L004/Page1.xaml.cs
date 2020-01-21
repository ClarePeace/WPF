using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Page1.xaml 的交互逻辑
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //这里不要使用创建Page 要使用NavigationService
            NavigationService.Navigate(new Uri("L004/Page2.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }

        private void Baidu_Click(object sender, RoutedEventArgs e)
        {

            Hyperlink link = sender as Hyperlink;
            //Process.Start(new ProcessStartInfo(link.NavigateUri.AbsoluteUri));//可能在当前浏览器也会跳转
            NavigationService.Navigate(link.NavigateUri);//不要加.AbsoluteUri 会只显示一个物理地址
        }
    }
}
