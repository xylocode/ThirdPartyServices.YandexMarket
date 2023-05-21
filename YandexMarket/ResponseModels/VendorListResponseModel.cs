using System.Collections.Generic;
using XyloCode.ThirdPartyServices.YandexMarket.Entities;

namespace XyloCode.ThirdPartyServices.YandexMarket.ResponseModels
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/vendor-controller-v2-get-vendor-list.html">Список производителей</a>
    /// Возвращает список производителей, товары которых размещаются на Яндекс.Маркете
    /// Ресурс является списочным.
    /// </summary>
    public class VendorListResponseModel : BaseResponseModel
    {
        /// <summary>
        /// Список производителей
        /// </summary>
        public ICollection<Vendor> Vendors { get; set; }
    }
}
