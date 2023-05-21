using XyloCode.ThirdPartyServices.YandexMarket.Enum;

namespace XyloCode.ThirdPartyServices.YandexMarket.QueryModels
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/shops-controller-v2-get-shop-list.html">Поиск магазина по хосту или URL</a>
    /// Возвращает информацию о найденном магазине по указанному в запросе хосту или URL. Можно дополнительно задать регион поиска магазина.
    /// Ресурс является регионозависимым.
    /// </summary>
    public class ShopSearchQueryModel : BaseQueryModel
    {
        public override string GetPath() => $"/{version}/shops";

        public ShopSearchQueryModel(string host)
        {
            this.host = host;
        }

        /// <summary>
        /// Хост или URL магазина, который требуется найти.
        /// Внимание. При поиске поддомен (включая www) не отбрасывается.
        /// Если в параметре host вы указали www.media.seller.ru, магазин media.seller.ru найден не будет.
        /// Если в параметре host вы указали media.seller.ru, магазин seller.ru найден не будет.
        /// </summary>
        public string host { get; set; }


        /// <summary>
        /// Свойства магазинов, которые необходимо показать в выходных данных.
        /// </summary>
        public ShopFields? fields { get; set; }

        /// <summary>
        /// Идентификатор региона, в котором необходимо найти указанный магазин.
        /// </summary>
        public int geo_id { get; set; }
    }
}
