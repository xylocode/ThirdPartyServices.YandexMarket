using System.Collections.Generic;
using XyloCode.ThirdPartyServices.YandexMarket.Entities;

namespace XyloCode.ThirdPartyServices.YandexMarket.ResponseModels
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/models-controller-v2-get-reviews.html/">Список обзоров на модель</a>
    /// Ресурс является списочным.
    /// </summary>
    public class ModelReviewListResponseModel : BaseResponseModel
    {
        /// <summary>
        /// Список обзоров на модель.
        /// </summary>
        public ICollection<ModelReview> Reviews { get; set; }
    }
}
