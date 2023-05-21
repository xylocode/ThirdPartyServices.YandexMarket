using System.Collections.Generic;
using XyloCode.ThirdPartyServices.YandexMarket.Entities;

namespace XyloCode.ThirdPartyServices.YandexMarket.ResponseModels
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/geo-controller-v2-suggest.html/">Текстовый поиск региона</a>
    /// Возвращает список регионов, подходящих под заданные условия поиска.
    /// Можно задать поиск по полному или частичному названию региона.
    /// В случае указания частичного названия в выходных данных возвращается список регионов, название которых начинается с этого частичного названия.
    /// </summary>
    public class RegionTextSearchResponseModel : BaseResponseModel
    {
        /// <summary>
        /// Список регионов в результате поиска по частичному или полному наименованию
        /// </summary>
        public ICollection<Region> Suggests { get; set; }
    }
}
