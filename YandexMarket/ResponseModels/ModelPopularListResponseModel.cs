using System.Collections.Generic;
using XyloCode.ThirdPartyServices.YandexMarket.Entities;

namespace XyloCode.ThirdPartyServices.YandexMarket.ResponseModels
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/category-controller-v2-get-popular-models.html/">Список популярных моделей</a>
    /// Возвращает популярные на Яндекс.Маркете модели.
    /// Ресурс является списочным.
    /// </summary>
    public class ModelPopularListResponseModel : BaseResponseModel
    {
        /// <summary>
        /// Список моделей.
        /// </summary>
        public ICollection<ModelV2> Models { get; set; }
    }
}
