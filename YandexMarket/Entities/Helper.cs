using System;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace XyloCode.ThirdPartyServices.YandexMarket.Entities
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
    }
}
