using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonOperate
{
    /// <summary>
    /// 支持使用 Newtonsoft.Json 程序包序列化成 Json 的对象。
    /// </summary>
    /// <remarks>
    /// 对象的属性必须是 public 且必须是属性包装的。否则将无法识别。
    /// </remarks>
    class DemoObject
    {
        public string Name { get; set; }
        public string ID { get; set; }
    }
}
