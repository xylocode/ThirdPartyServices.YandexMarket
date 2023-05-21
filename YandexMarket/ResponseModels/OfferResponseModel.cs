using XyloCode.ThirdPartyServices.YandexMarket.Entities;

namespace XyloCode.ThirdPartyServices.YandexMarket.ResponseModels
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/offers-controller-v2-get-offer.html">Информация о товарном предложении</a>
    /// Возвращает информацию об указанном товарном предложении.
    /// Ресурс является регионозависимым.
    /// </summary>
    public class OfferResponseModel : BaseResponseModel
    {
        /// <summary>
        /// Информация о товарном предложении
        /// </summary>
        public Offer Offer { get; set; }
    }
}
