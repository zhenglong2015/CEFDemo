using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CEFDemo
{
    /// <summary>
    /// 与HTMLx交互类
    /// </summary>
    public class CallbackObjectForJs
    {
        /// <summary>
        /// 在js中调用的方法
        /// </summary>
        /// <param name="msg"></param>
        public void ShowMessage(string msg)
        {
            MessageBox.Show(msg);
        }
    }
}
