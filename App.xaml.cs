using CefSharp;
using CefSharp.Wpf;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace CEFDemo
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            //var settings = new CefSettings() { };
            //Cef.Initialize(settings, performDependencyCheck: false, browserProcessHandler: null);

            //设置可以注册JSd对象
            CefSharpSettings.LegacyJavascriptBindingEnabled = true;
        }

    }
}
