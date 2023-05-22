using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Unicode;
using XyloCode.ThirdPartyServices.YandexMarket.QueryModels;

namespace XyloCode.ThirdPartyServices.YandexMarket
{
    internal static class Helper
    {
        static readonly JsonSerializerOptions jso;

        static Helper()
        {
            jso = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic)
            };
            jso.Converters.Add(new JsonStringEnumConverter());
        }


        public static string Serialize<T>(T obj)
            where T : class
        {
            if (obj == null)
                return null;

            return JsonSerializer.Serialize(obj, jso);
        }

        public static T Deserialize<T>(string s)
            where T : class
        {
            if (!string.IsNullOrWhiteSpace(s))
            {
                return JsonSerializer.Deserialize<T>(s, jso);
            }
            return null;
        }

        public static long GetUnixTime() => new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
        public static List<KeyValuePair<string, string>> GetQuery<TRequest>(TRequest request)
             where TRequest : BaseQueryModel
        {
            var list = new List<KeyValuePair<string, string>>();
            var props = typeof(TRequest)
                .GetProperties(BindingFlags.Instance | BindingFlags.Public);

            object value;
            KeyValuePair<string, string> kvp;
            for (int i = 0; i < props.Length; i++)
            {
                if (props[i].GetCustomAttribute<IgnoreDataMemberAttribute>() != null)
                    continue;

                value = props[i].GetValue(request);
                if (value == null)
                    continue;

                kvp = new KeyValuePair<string, string>(props[i].Name, value.ToString());
                list.Add(kvp);
            }
            return list;
        }
    }
}
