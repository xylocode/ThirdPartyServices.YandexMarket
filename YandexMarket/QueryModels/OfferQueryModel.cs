using System.Runtime.Serialization;
using XyloCode.ThirdPartyServices.YandexMarket.Enum;

namespace XyloCode.ThirdPartyServices.YandexMarket.QueryModels
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/offers-controller-v2-get-offer.html">Информация о товарном предложении</a>
    /// Возвращает информацию об указанном товарном предложении.
    /// Ресурс является регионозависимым.
    /// </summary>
    public class OfferQueryModel : BaseQueryModel
    {
        public override string GetPath() => $"/{version}/offers/{id}";


        public OfferQueryModel(string offerId, int geoId)
        {
            id = offerId;
            geo_id = geoId;
        }

        /// <summary>
        /// Идентификатор товарного предложения
        /// </summary>
        [IgnoreDataMember]
        public string id { get; set; }


        /// <summary>
        /// Идентификатор региона, для которого нужно получить информацию о предложении.
        /// </summary>
        public int geo_id { get; set; }


        /// <summary>
        /// Признак включения цены доставки в цену товарного предложения.
        /// Значение по умолчанию: ЛОЖЬ.
        /// </summary>
        public bool? delivery_included { get; set; }

        /// <summary>
        /// Параметры предложений, которые необходимо показать в выходных данных.
        /// </summary>
        public OfferFields? fields { get; set; }
    }
}
