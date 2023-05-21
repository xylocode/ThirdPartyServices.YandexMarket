using System.Runtime.Serialization;

namespace XyloCode.ThirdPartyServices.YandexMarket.QueryModels
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/models-controller-v2-get-reviews.html/">Список обзоров на модель</a>
    /// Ресурс является списочным.
    /// </summary>
    public class ModelReviewListQueryModel : BaseQueryModel
    {
        public override string GetPath() => $"/{version}/models/{id}/reviews";

        public ModelReviewListQueryModel(long modelId)
        {
            id = modelId;
        }

        /// <summary>
        /// Идентификатор модели.
        /// </summary>
        [IgnoreDataMember]
        public long id { get; set; }

        ///// <summary>
        ///// Размер страницы (количество элементов на странице).
        ///// Ограничения: минимальное значение: 1; максимальное значение: 30.
        ///// Значение по умолчанию: 10.
        ///// </summary>
        //public int? count { get; set; }

        ///// <summary>
        ///// Номер страницы.
        ///// Ограничения: минимальное значение: 1.
        ///// Значение по умолчанию: 1.
        ///// </summary>
        //public int? page { get; set; }
    }
}
