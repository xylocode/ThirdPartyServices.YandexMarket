using XyloCode.ThirdPartyServices.YandexMarket.Entities;

namespace XyloCode.ThirdPartyServices.YandexMarket.ResponseModels
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/vendor-controller-v2-match-vendor.html">Подбор производителя по названию</a>
    /// Возвращает производителя, наиболее подходящего под заданное во входных данных название
    /// </summary>
    public class VendorMatchResponseModel : BaseResponseModel
    {
        /// <summary>
        /// Информация о производителе
        /// </summary>
        public Vendor Vendor { get; set; }
    }
}
