using System;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Web;
using XyloCode.ThirdPartyServices.YandexMarket.QueryModels;
using XyloCode.ThirdPartyServices.YandexMarket.ResponseModels;


namespace XyloCode.ThirdPartyServices.YandexMarket
{
    public class YandexMarketConnection
    {
        #region MAIN
        readonly string server;
        readonly string apiKey;
        readonly HttpClient httpClient;
        readonly JsonSerializerOptions jsonSerializerOptions;


        public YandexMarketConnection(string server, string apiKey)
        {
            this.server = server.TrimEnd('/');
            this.apiKey = apiKey;
            httpClient = new HttpClient();

            #region JSON options
            jsonSerializerOptions = new JsonSerializerOptions();

            var jsonStringEnumConverter = new JsonStringEnumConverter();
            jsonSerializerOptions.Converters.Add(jsonStringEnumConverter);

            jsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
            #endregion
        }

        public TResponse Request<TRequest, TResponse>(TRequest request, out string content)
            where TRequest : BaseQueryModel
            where TResponse : BaseResponseModel, new()
        {
            start:
            var query = HttpUtility.ParseQueryString(string.Empty);

            var collection = Helpers.GetQuery(request);
            foreach (var item in collection)
                query[item.Key] = item.Value;

            collection = request.GetDynamicAttributeValuePairs();
            if (collection != null)
            {
                foreach (var item in collection)
                    query[item.Key] = item.Value;
            }

            query["api_key"] = apiKey;
            var requestUri = $"{server}{request.GetPath()}?{query}";
            

            int attempts = 10;
            HttpResponseMessage respMsg;
            do
            {
                Thread.Sleep(1000);

                try
                {
                    respMsg = httpClient.GetAsync(requestUri).Result;
                    content = respMsg.Content.ReadAsStringAsync().Result;
                }
                catch (Exception ex)
                {
                    ConsoleWriteLine(ConsoleColor.Red, ex.Message);
                    continue;
                }

                switch (respMsg.StatusCode)
                {
                    case HttpStatusCode.OK:
                        if (content.Contains("Error occurred, please try again later"))
                        {
                            ConsoleWriteLine(ConsoleColor.Green, "Ошибка провайдера данных");
                            Thread.Sleep(30_000);
                            continue;
                        }

                        try
                        {
                            return JsonSerializer.Deserialize<TResponse>(content, jsonSerializerOptions);
                        }
                        catch (Exception ex)
                        {
                            if (ex.Message.Contains("Expected end of string, but instead reached end of data."))
                            {
                                request.page -= 10;
                                goto start;
                            }
                            ConsoleWriteLine(ConsoleColor.Red, ex.Message);
                            Thread.Sleep(30_000);
                            continue;
                        }

                    case HttpStatusCode.Forbidden:
                        
                        if (content.Contains("Thread limit"))
                        {
                            ConsoleWriteLine(ConsoleColor.Yellow, "{0} — превышение частоты запросов", respMsg.StatusCode);
                            Thread.Sleep(5_000);
                            continue;
                        }


                        if (content.Contains("Forbidden"))
                        {
                            ConsoleWriteLine(ConsoleColor.Yellow, "{0} — постоянные нарушения частоты запросов", respMsg.StatusCode);
                            Thread.Sleep(30_000);
                            continue;
                        }


                        if (content.Contains("Rate limit exceeded"))
                        {
                            ConsoleWriteLine(ConsoleColor.Red, "{0} — исчерпан лимит запросов в сутки. Следующая попытка через 1 час.", respMsg.StatusCode);
                            Thread.Sleep(3_600_000);
                            continue;
                        }


                        if (content.Contains("Access no paid"))
                        {
                            ConsoleWriteLine(ConsoleColor.Red, "{0} — доступ не оплачен", respMsg.StatusCode);
                            return null;
                        }


                        if (content.Contains("Access denied"))
                        {
                            ConsoleWriteLine(ConsoleColor.Red, "{0} — неверный API-ключ", respMsg.StatusCode);
                            return null;
                        }
                        return null;


                    default:
                        ConsoleWriteLine(ConsoleColor.Magenta, "{0}: {1}", respMsg.StatusCode, content);
                        Thread.Sleep(30_000);
                        continue;

                }

            } while (--attempts > 0);

            content = null;
            return null;
        }
        #endregion


        static void ConsoleWriteLine(ConsoleColor foregroundColor, string message, params object[] args)
        {
            Console.ForegroundColor = foregroundColor;
            Console.WriteLine(message, args);
            Console.ResetColor();
        }
    }
}
