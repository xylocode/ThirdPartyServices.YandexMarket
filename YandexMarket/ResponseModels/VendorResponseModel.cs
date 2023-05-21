using XyloCode.ThirdPartyServices.YandexMarket.Entities;

namespace XyloCode.ThirdPartyServices.YandexMarket.ResponseModels
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/vendor-controller-v2-get-vendor.html/">Информация о производителе</a>
    /// Возвращает информацию об указанном производителе
    /// </summary>
    public class VendorResponseModel : BaseResponseModel
    {
        /// <summary>
        /// Информация о производителе
        /// </summary>
        public Vendor Vendor { get; set; }
    }
}
