using System.Runtime.Serialization;
using XyloCode.ThirdPartyServices.YandexMarket.Enum;

namespace XyloCode.ThirdPartyServices.YandexMarket.QueryModels
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/shops-controller-v2-get-shop.html/">Информация о магазине</a>
    /// Возвращает информацию об указанном магазине.
    /// </summary>
    public class ShopQueryModel : BaseQueryModel
    {
        public override string GetPath() => $"/{version}/shops/{id}";

        public ShopQueryModel(long shopId)
        {
            id = shopId;
        }

        /// <summary>
        /// Идентификатор магазина
        /// </summary>
        [IgnoreDataMember]
        public long id { get; set; }

        /// <summary>
        /// Свойства магазинов, которые необходимо показать в выходных данных.
        /// </summary>
        public ShopFields? fields { get; set; }
    }
}
