using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace OnWindowCreated
{
    class MainViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// 当窗口渲染完成之后。
        /// </summary>
        /// <remarks>
        /// 在 MainWIndow 下和 ContentRendered 事件进行关联。
        /// </remarks>
        internal void OnMainWindowContentRendered(object sender, EventArgs e)
        {

            /* do something */

        }


        #region INotifyPropertyChanged接口实现
        #region PropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
        #endregion
    }
}
