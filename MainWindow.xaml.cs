using CefSharp;
using CefSharp.Wpf;
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

namespace CEFDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //注册JS对象处理类
            webBrowser.RegisterJsObject("callbackObj", new CallbackObjectForJs());

            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //获取文件的物理路径
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\HTMLTestPage.html";

            //转换为File协议路径
            webBrowser.Address = "file://" + path.Replace("\\", "/");

            //设置禁用右键菜单
            webBrowser.MenuHandler = new MenuHandler();
        }
    }
}
