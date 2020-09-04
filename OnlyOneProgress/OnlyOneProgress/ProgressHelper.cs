using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OnlyOneProgress
{
    /// <summary>
    /// 进程辅助类。
    /// </summary>
    public class ProgressHelper
    {
        // 用于激活已打开的窗体
        [DllImport("user32.dll")]
        public static extern void SetForegroundWindow(IntPtr hwnd);
        //操作当前窗体
        //nCmdShow: 0关闭窗口/1正常大小显示窗口/2最小化窗口/3最大化窗口
        [DllImport("user32.dll")]
        public static extern int ShowWindow(IntPtr hwnd, int nCmdShow);



        /// <summary>
        /// 检测程序是否已经存在实例正在运行。如果存在，将该进程实例激活；否则创建新的进程。
        /// </summary>
        /// <returns></returns>
        public static bool ProgressHasExecute()
        {
            // 模块名称，如 abc.exe
            string MName = System.Diagnostics.Process.GetCurrentProcess().MainModule.ModuleName;
            // 模块名称，去掉后缀，如 abc 
            string PName = System.IO.Path.GetFileNameWithoutExtension(MName);
            // 获得已经运行了的模块。
            System.Diagnostics.Process[] myProcess = System.Diagnostics.Process.GetProcessesByName(PName);

            if (myProcess.Length > 1)
            {
                // 将已经打开的应用进行显示。
                SetForegroundWindow(myProcess[0].MainWindowHandle);
                ShowWindow(myProcess[0].MainWindowHandle, 1);

                return true;
            }

            return false;
        }
    }
}
