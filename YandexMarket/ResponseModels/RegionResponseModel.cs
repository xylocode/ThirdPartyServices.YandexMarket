using XyloCode.ThirdPartyServices.YandexMarket.Entities;

namespace XyloCode.ThirdPartyServices.YandexMarket.ResponseModels
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/geo-controller-v2-get-region.html">Информация о регионе</a>
    /// </summary>
    public class RegionResponseModel : BaseResponseModel
    {
        /// <summary>
        /// Информация о запрашиваемом регионе
        /// </summary>
        public Region Region { get; set; }
    }
}
