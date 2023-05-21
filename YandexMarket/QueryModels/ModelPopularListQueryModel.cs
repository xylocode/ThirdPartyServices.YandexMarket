using System.Runtime.Serialization;
using XyloCode.ThirdPartyServices.YandexMarket.Enum;

namespace XyloCode.ThirdPartyServices.YandexMarket.QueryModels
{
    /// <summary>
    /// <a href="https://yandex.ru/dev/market/content-data/doc/dg-v2/reference/category-controller-v2-get-popular-models.html/">Список популярных моделей</a>
    /// Возвращает популярные на Яндекс.Маркете модели.
    /// Ресурс является списочным.
    /// </summary>
    public class ModelPopularListQueryModel : BaseQueryModel
    {
        public override string GetPath() => $"/{version}/categories/{hid}/populars";

        public ModelPopularListQueryModel(int categoryId)
        {
            hid = categoryId;
        }

        /// <summary>
        /// Идентификатор категории.
        /// </summary>
        [IgnoreDataMember]
        public int hid { get; set; }

        /// <summary>
        /// Свойства модели, которые необходимо показать в выходных данных.
        /// </summary>
        public ModelFields? fields { get; set; }

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
