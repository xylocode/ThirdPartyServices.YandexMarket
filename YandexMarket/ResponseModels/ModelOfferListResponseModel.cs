using System.Collections.Generic;
using XyloCode.ThirdPartyServices.YandexMarket.Entities;

namespace XyloCode.ThirdPartyServices.YandexMarket.ResponseModels
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/models-controller-v2-get-offers.html/">Список предложений на модель</a>
    /// Возвращает список товарных предложений, соотнесенных с указанной моделью.
    /// Ресурс является списочным.
    /// </summary>
    public class ModelOfferListResponseModel : BaseResponseModel
    {
        /// <summary>
        /// Список товарных предложений модели.
        /// </summary>
        public ICollection<Offer> Offers { get; set; }

        /// <summary>
        /// Список фильтров, доступных для фильтрации товарных предложений модели
        /// Типы:
        /// фильтр;
        /// фильтр со значениями;
        /// числовой фильтр.
        /// </summary>
        public ICollection<Filter> Filters { get; set; }

        /// <summary>
        /// Список доступных сортировок товарных предложений модели.
        /// </summary>
        public ICollection<ModelSort> Sorts { get; set; }
    }
}
