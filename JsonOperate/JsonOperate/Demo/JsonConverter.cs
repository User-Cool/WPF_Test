using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonOperate
{
    /// <summary>
    /// Json 是一种字符串，可以保存对象的数据信息。
    /// </summary>
    /// <remarks>
    /// 在 JavaScript 环境下，Json 很容易能够转换成对象，C# 和 JavaScript 类似，
    /// 很幸运的是，通过 Newtonsoft.Json 程序包可以很方便的 Json 和对象之间的转换。
    /// 
    /// 需要注意的是，对象的属性必须是 public 包装过的，具体可以参考 <see cref="DemoObject"/>
    /// </remarks>
    class JsonConverter
    {
        /// <summary>
        /// 序列化成 json 格式的字符串。
        /// </summary>
        /// <returns> Json 格式的字符串 </returns>
        public StringWriter DemoObjectToJsonString()
        {
            DemoObject jsonDemoData = new DemoObject();

            JsonSerializer jsonSerializer = new JsonSerializer();
            StringWriter stringWriter = new StringWriter();
            jsonSerializer.Serialize(stringWriter, jsonDemoData);

            return stringWriter;
        }

        /// <summary>
        /// 将 Json 格式字符串解析成对象。
        /// </summary>
        /// <returns>转换成的对象</returns>
        public DemoObject JsonStringToDemoObject()
        {
            string json = File.ReadAllText("_path");

            StringReader stringReader = new StringReader(json);
            JsonTextReader jsonTextReader = new JsonTextReader(stringReader);
            JsonSerializer jsonSerializer = new JsonSerializer();
            return jsonSerializer.Deserialize<DemoObject>(jsonTextReader);
        }
    }
}
