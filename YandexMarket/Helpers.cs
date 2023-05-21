using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;
using XyloCode.ThirdPartyServices.YandexMarket.QueryModels;

namespace XyloCode.ThirdPartyServices.YandexMarket
{
    static class Helpers
    {
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
