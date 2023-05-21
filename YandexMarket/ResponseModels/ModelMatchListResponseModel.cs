using System.Collections.Generic;
using XyloCode.ThirdPartyServices.YandexMarket.Entities;

namespace XyloCode.ThirdPartyServices.YandexMarket.ResponseModels
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/models-controller-v2-get-matched-models.html">Поиск модели по названию и параметрам</a>
    /// Возвращает модель из гуризованной категории по названию и параметрам, удовлетворяющим заданным во входных данных условиям поиска.
    /// </summary>
    public class ModelMatchListResponseModel : BaseResponseModel
    {
        /// <summary>
        /// Список моделей.
        /// </summary>
        public ICollection<ModelV2> Models { get; set; }
    }
}
