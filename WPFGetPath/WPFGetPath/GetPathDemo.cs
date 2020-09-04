using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPFGetPath
{
    class GetPathDemo
    {

        public GetPathDemo()
        {

            //获取基目录即当前工作目录 F:\\WPF实例\\bin\\Debug\\
            string str_1 = System.AppDomain.CurrentDomain.BaseDirectory;

            //获取应用程序基目录的名称 F:\\WPF实例\\bin\\Debug\\
            string str_2 = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;

            // 获取当前进程模块的完整路径。
            // 调试状态: F:\\WPF实例\\bin\\Debug\\WPF实例.vshost.exe 
            // 非调试状态)：F:\\WPF实例\\bin\\Debug\\WPF实例.exe
            string str_5 = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;

            //获取或设置当前工作目录的完全限定路径。 F:\\WPF实例\\bin\\Debug
            string str_6 = System.Environment.CurrentDirectory;

            //通IO的通过目录和子目录的静态方法 F:\\WPF实例\\bin\\Debug
            string str_8 = System.IO.Directory.GetCurrentDirectory();
        }

    }
}
