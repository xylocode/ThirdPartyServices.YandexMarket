using System.Collections.Generic;
using XyloCode.ThirdPartyServices.YandexMarket.Entities;

namespace XyloCode.ThirdPartyServices.YandexMarket.ResponseModels
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/shops-controller-v2-get-shop-list.html">Поиск магазина по хосту или URL</a>
    /// Возвращает информацию о найденном магазине по указанному в запросе хосту или URL. Можно дополнительно задать регион поиска магазина.
    /// Ресурс является регионозависимым.
    /// </summary>
    public class ShopSearchResponseModel : BaseResponseModel
    {
        /// <summary>
        /// Список магазинов
        /// </summary>
        public ICollection<Shop> Shops { get; set; }
    }
}
