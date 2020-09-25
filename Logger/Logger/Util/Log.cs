using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Util
{
    /// <summary>
    /// 日志。
    /// </summary>
    /// <remarks>
    /// 使用日志是非常有必要的。在生产环境下，日志是我们调试程序的唯一选择。
    /// 
    /// 在开发环境下，出现问题，定位问题是相对容易的，但是，在离开开发环境之后，
    /// 没有了断点，如果程序出现什么问题，那么查找将变得异常困难（在开发环境添加查找错误的代码，然后发布到运行环境，运行测试，如此反复）。
    /// 
    /// 此时，如果使用日志，就可以将日志打开，设置成调试模式，然后运行，就会得到调试日志，来帮助我们定位问题。
    /// </remarks>
    /// <remarks 2>
    /// 日志的设计
    /// 
    /// 日志虽然重要但毕竟不是业务逻辑所需要的，因此日志应当尽量小的影响业务逻辑。如果因为日志的加入导致
    /// 业务逻辑执行的时候出现问题（如卡顿）就得不偿失了。
    /// 
    /// 日志应当具有的内容：
    /// [2012-03-02T20:20:49.003+02:00][123654789][info] Bootstrapping application (v 2.1b)
    /// 其中，依次为：时间 id 日志等级 日志信息。
    /// </remarks 2>
    class Log
    {
        /// <summary>
        /// 调试日志。
        /// </summary>
        /// <remarks>
        /// 打印调试信息。函数名、参数名和值
        /// </remarks>
        public void Debug()
        {
            
        }

        /// <summary>
        /// 信息日志。
        /// </summary>
        /// <remarks>
        /// 打印一些感兴趣的内容。也就是你想打印的内容。
        /// </remarks>
        public void Info()
        {

        }

        /// <summary>
        /// 跟踪日志。
        /// </summary>
        /// <remarks>
        /// 跟踪，跟踪一个逻辑的执行。
        /// </remarks>
        public void Trace()
        {

        }

        /// <summary>
        /// 错误日志。
        /// </summary>
        /// <remarks>
        /// 这种错误一般能够拯救回来。
        /// </remarks>
        public void Error()
        {

        }

        /// <summary>
        /// 致命的日志。
        /// </summary>
        /// <remarks>
        /// 出现这种错误表示重新无法继续执行。
        /// </remarks>
        public void Fatal()
        {

        }
    }
}
