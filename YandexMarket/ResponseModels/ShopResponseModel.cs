using XyloCode.ThirdPartyServices.YandexMarket.Entities;

namespace XyloCode.ThirdPartyServices.YandexMarket.ResponseModels
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/shops-controller-v2-get-shop.html/">Информация о магазине</a>
    /// Возвращает информацию об указанном магазине.
    /// </summary>
    public class ShopResponseModel:BaseResponseModel
    {
        /// <summary>
        /// Информация о магазине
        /// </summary>
        public Shop Shop { get; set; }
    }
}
