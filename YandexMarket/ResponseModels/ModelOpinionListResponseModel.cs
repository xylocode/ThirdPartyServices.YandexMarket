using System.Collections.Generic;
using XyloCode.ThirdPartyServices.YandexMarket.Entities;

namespace XyloCode.ThirdPartyServices.YandexMarket.ResponseModels
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/opinions-controller-v2-get-model-opinions.html/">Отзывы о модели</a>
    /// Возвращает отзывы пользователей о модели. Оценки без отзывов не входят в ответ.
    /// Ресурс является списочным.
    /// </summary>
    public class ModelOpinionListResponseModel : BaseResponseModel
    {
        /// <summary>
        /// Отзывы
        /// </summary>
        public ICollection<ModelOpinion> Opinions { get; set; }
    }
}
