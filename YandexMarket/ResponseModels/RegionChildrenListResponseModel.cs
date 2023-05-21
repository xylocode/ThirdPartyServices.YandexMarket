using System.Collections.Generic;
using XyloCode.ThirdPartyServices.YandexMarket.Entities;

namespace XyloCode.ThirdPartyServices.YandexMarket.ResponseModels
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/geo-controller-v2-get-children.html">Список дочерних регионов</a>
    /// Ресурс является списочным.
    /// 
    /// </summary>
    public class RegionChildrenListResponseModel : BaseResponseModel
    {
        /// <summary>
        /// Список регионов
        /// </summary>
        public ICollection<Region> Regions { get; set; }
    }
}
