using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonOperate
{
    class JsonFileDemo
    {
        /// <summary>
        /// 序列化成json格式的字符串。
        /// </summary>
        /// <returns></returns>
        private StringWriter ProgressesToJsonString()
        {
            JsonDemoData jsonDemoData = new JsonDemoData();

            JsonSerializer jsonSerializer = new JsonSerializer();
            StringWriter stringWriter = new StringWriter();
            jsonSerializer.Serialize(stringWriter, jsonDemoData);

            return stringWriter;
        }

        /// <summary>
        /// 将Json格式字符串解析成对象。
        /// </summary>
        /// <returns></returns>
        private JsonDemoData JsonStringToProgresses()
        {
            var json = File.ReadAllText("_path");
            StringReader stringReader = new StringReader(json);
            JsonTextReader jsonTextReader = new JsonTextReader(stringReader);
            JsonSerializer jsonSerializer = new JsonSerializer();
            return jsonSerializer.Deserialize<JsonDemoData>(jsonTextReader);
        }
    }
}
